using TasksManager.API.DTOs;
using TasksManager.API.DTOs.Tasks;
using TasksManager.API.Mappings;
using TasksManager.API.Models;
using TasksManager.API.Repositories.Interfaces;
using TasksManager.API.Services.Interfaces;

namespace TasksManager.API.Services
{
    public class TasksService : ITasksService
    {
        private readonly ITasksRepository _tasksRepository;

        public TasksService(ITasksRepository tasksRepository)
        {
            _tasksRepository = tasksRepository;
        }
        public async Task<List<TaskDTO>> GetAllTasks()
        {
            var tasks = await _tasksRepository.GetAllTasks();

            return tasks.ToTaskDTOList();
        }

        public async Task<TaskDTO> GetTaskById(Guid id)
        {
            var task = await _tasksRepository.GetTaskById(id);

            if (task == null)
                throw new ArgumentException("Task não encontrada");

            return task.ToTaskDTO();
        }

        public async Task<TaskDTO> AddTask(AddTaskRequest request)
        {
            var task = new TaskModel(request.ProjectId, request.Name, request.Description); 

            var newTask = await _tasksRepository.AddTask(task);

            if (newTask == null)
                throw new ArgumentException("Falha ao cadastrar nova task");

            return newTask.ToTaskDTO();
        }

        public async Task<TaskDTO> UpdateTask(UpdateTaskRequest request)
        {
            var task = await _tasksRepository.GetTaskById(request.Id);

            if (task == null)
                throw new ArgumentException("Essa task não existe");

            var taskUdpate = request.ToTaskModel();

            taskUdpate.Update();

            var result = await _tasksRepository.UpdateTask(taskUdpate);

            if (result == null)
                throw new ArgumentException("Falha ao atualizar task");

            return result.ToTaskDTO();
        }

        public async Task DeleteTask(Guid id)
        {
            var task = await _tasksRepository.GetTaskById(id);

            if (task is null)
                throw new ArgumentNullException("Task não encontrada");

            task.Delete();

            await _tasksRepository.DeleteTask(task);
        }
    }
}