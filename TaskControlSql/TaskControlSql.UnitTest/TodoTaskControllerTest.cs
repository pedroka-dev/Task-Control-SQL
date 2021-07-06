using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskControlSql.Control;
using TaskControlSql.Domain;

namespace TaskControlSql.UnitTest
{
    [TestClass]
    public class TodoTaskControllerTest
    {
        TodoTaskController taskController;
        public TodoTaskControllerTest()
        {
            taskController = new TodoTaskController();
            taskController.DeleteAllEntities();
        }

        [TestMethod]
        public void Should_ReturnOpSucess_OnInsertNewTask()
        {
            int correctId = 0;
            string correctPriority = "High";
            string correctTitle = "Test Task";
            DateTime corectCreationTime = DateTime.Today;

            TodoTask todoTask = new TodoTask(correctId, correctPriority, correctTitle, corectCreationTime);
            string response = taskController.CreateEntity(todoTask);

            response.Should().Be("OP_SUCCESS");
            taskController.ReceiveEntity(todoTask.Id).Should().Be(todoTask);
        }

        [TestMethod]
        public void Should_ReturnOpSucess_OnInsertInProgressTask()
        {
            int correctId = 0;
            string correctPriority = "High";
            string correctTitle = "Test Task";
            DateTime correctCreationTime = DateTime.Today;

            TodoTask todoTask = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            todoTask.UpdatePercentageConcluded(50, DateTime.Today);
            string response = taskController.CreateEntity(todoTask);

            response.Should().Be("OP_SUCCESS");
            taskController.ReceiveEntity(todoTask.Id).Should().Be(todoTask);
        }

        [TestMethod]
        public void Should_ReturnOpSucess_OnInsertConcludedTask()
        {
            int correctId = 0;
            string correctPriority = "High";
            string correctTitle = "Test Task";
            DateTime correctCreationTime = DateTime.Today;

            TodoTask todoTask = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            todoTask.UpdatePercentageConcluded(100, DateTime.Today);
            string response = taskController.CreateEntity(todoTask);

            response.Should().Be("OP_SUCCESS");
            taskController.ReceiveEntity(todoTask.Id).Should().Be(todoTask);
        }

        [TestMethod]
        public void Should_ReturnOpSucess_OnInsertMultipleTasks()
        {
            int correctId = 0;
            string correctPriority = "High";
            string correctTitle = "Test Task";
            DateTime correctCreationTime = DateTime.Today;
            taskController.DeleteAllEntities();

            TodoTask todoTask1 = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            TodoTask todoTask2 = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            TodoTask todoTask3 = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            string response1 = taskController.CreateEntity(todoTask1);
            string response2 = taskController.CreateEntity(todoTask2);
            string response3 = taskController.CreateEntity(todoTask3);

            response1.Should().Be("OP_SUCCESS");
            taskController.ReceiveEntity(todoTask1.Id).Should().Be(todoTask1);
            response1.Should().Be("OP_SUCCESS");
            taskController.ReceiveEntity(todoTask1.Id).Should().Be(todoTask1);
            response1.Should().Be("OP_SUCCESS");
            taskController.ReceiveEntity(todoTask1.Id).Should().Be(todoTask1);
        }

        [TestMethod]
        public void Should_ReturnOpSucess_OnUpdateNewTask()
        {
            int correctId = 0;
            string correctPriority = "High";
            string correctTitle = "Test Task";
            DateTime correctCreationTime = DateTime.Today;
            string newCorrectPriority = "Medium";
            string newCorrectTitle = "Test Task Updated";

            TodoTask todoTask = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            TodoTask updatedTodoTask = new TodoTask(correctId, newCorrectPriority, newCorrectTitle, correctCreationTime);
            taskController.CreateEntity(todoTask);
            updatedTodoTask.Id = todoTask.Id;
            string response = taskController.UpdateEntity(updatedTodoTask);

            response.Should().Be("OP_SUCCESS");
            taskController.ReceiveEntity(updatedTodoTask.Id).Should().Be(updatedTodoTask); ;
        }

        [TestMethod]
        public void Should_ReturnOpSucess_OnUpdateInProgressTask()
        {
            int correctId = 0;
            string correctPriority = "High";
            string correctTitle = "Test Task";
            DateTime correctCreationTime = DateTime.Today;
            string newCorrectPriority = "Medium";
            string newCorrectTitle = "Test Task Updated";

            TodoTask todoTask = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            TodoTask updatedTodoTask = new TodoTask(correctId, newCorrectPriority, newCorrectTitle, correctCreationTime);
            updatedTodoTask.UpdatePercentageConcluded(50, DateTime.Now);
            taskController.CreateEntity(todoTask);
            updatedTodoTask.Id = todoTask.Id;
            string response = taskController.UpdateEntity(updatedTodoTask);


            response.Should().Be("OP_SUCCESS");
            taskController.ReceiveEntity(updatedTodoTask.Id).Should().Be(updatedTodoTask); ;
        }

        [TestMethod]
        public void Should_ReturnOpSucess_OnUpdateConcludedTask()
        {
            int correctId = 0;
            string correctPriority = "High";
            string correctTitle = "Test Task";
            DateTime correctCreationTime = DateTime.Today;
            string newCorrectPriority = "Medium";
            string newCorrectTitle = "Test Task Updated";

            TodoTask todoTask = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            TodoTask updatedTodoTask = new TodoTask(correctId, newCorrectPriority, newCorrectTitle, correctCreationTime);
            updatedTodoTask.UpdatePercentageConcluded(100, DateTime.Today);
            taskController.CreateEntity(todoTask);
            updatedTodoTask.Id = todoTask.Id;
            string response = taskController.UpdateEntity(updatedTodoTask);

            response.Should().Be("OP_SUCCESS");
            taskController.ReceiveEntity(updatedTodoTask.Id).Should().Be(updatedTodoTask); ;
        }

        [TestMethod]
        public void Should_ReturnFalse_OnExistEntityWithoutTodoTask()
        {
            int correctId = 0;
            string correctPriority = "High";
            string correctTitle = "Test Task";
            DateTime correctCreationTime = DateTime.Today;

            TodoTask todoTask = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            bool response = taskController.ExistEntity(todoTask.Id);

            response.Should().BeFalse();
        }

        [TestMethod]
        public void Should_ReturnTrue_OnExistEntityWithOneTodoTask()
        {
            int correctId = 0;
            string correctPriority = "High";
            string correctTitle = "Test Task";
            DateTime correctCreationTime = DateTime.Today;

            TodoTask todoTask = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            taskController.CreateEntity(todoTask);
            bool response = taskController.ExistEntity(todoTask.Id);

            response.Should().BeTrue();
        }

        [TestMethod]
        public void Should_ReturnTrue_OnExistEntityWithMultipleTodoTasks()
        {
            int correctId = 0;
            string correctPriority = "High";
            string correctTitle = "Test Task";
            DateTime correctCreationTime = DateTime.Today;

            TodoTask todoTask1 = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            TodoTask todoTask2 = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            TodoTask todoTask3 = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            taskController.CreateEntity(todoTask1);
            taskController.CreateEntity(todoTask2);
            taskController.CreateEntity(todoTask3);
            bool response1 = taskController.ExistEntity(todoTask1.Id);
            bool response2 = taskController.ExistEntity(todoTask2.Id);
            bool response3 = taskController.ExistEntity(todoTask3.Id);

            response1.Should().BeTrue();
            response2.Should().BeTrue();
            response3.Should().BeTrue();
        }
    }
}
