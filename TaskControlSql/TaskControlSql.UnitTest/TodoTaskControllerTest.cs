using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskControlSql.ConsoleApp.Control;
using TaskControlSql.ConsoleApp.Domain;

namespace TaskControlSql.UnitTest
{
    [TestClass]
    public class TodoTaskControllerTest
    {
        [TestMethod]
        public void Should_ReturnOpSucess_OnInsertNewTask()
        {
            int correctId = 0;
            string correctPriority = "High";
            string correctTitle = "Test Task";
            DateTime corectCreationTime = DateTime.Now;
            TodoTaskController taskController = new TodoTaskController();

            TodoTask todoTask = new TodoTask(correctId, correctPriority, correctTitle, corectCreationTime);
            taskController.DeleteAllEntities();
            string response = taskController.CreateEntity(todoTask);

            string expectedResponse = "OP_SUCCESS";
            Assert.AreEqual(expectedResponse, response);
        }

        [TestMethod]
        public void Should_ReturnOpSucess_OnInsertInProgressTask()
        {
            int correctId = 0;
            string correctPriority = "High";
            string correctTitle = "Test Task";
            DateTime correctCreationTime = DateTime.Now;
            TodoTaskController taskController = new TodoTaskController();
            taskController.DeleteAllEntities();

            TodoTask todoTask = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            todoTask.UpdatePercentageConcluded(50);
            string response = taskController.CreateEntity(todoTask);

            string expectedResponse = "OP_SUCCESS";
            Assert.AreEqual(expectedResponse, response);
        }

        [TestMethod]
        public void Should_ReturnOpSucess_OnInsertConcludedTask()
        {
            int correctId = 0;
            string correctPriority = "High";
            string correctTitle = "Test Task";
            DateTime correctCreationTime = DateTime.Now;
            TodoTaskController taskController = new TodoTaskController();
            taskController.DeleteAllEntities();

            TodoTask todoTask = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            todoTask.UpdatePercentageConcluded(100);
            string response = taskController.CreateEntity(todoTask);

            string expectedResponse = "OP_SUCCESS";
            Assert.AreEqual(expectedResponse, response);
        }

        [TestMethod]
        public void Should_ReturnOpSucess_OnInsertMultipleTasks()
        {
            int correctId = 0;
            string correctPriority = "High";
            string correctTitle = "Test Task";
            DateTime correctCreationTime = DateTime.Now;
            TodoTaskController taskController = new TodoTaskController();
            taskController.DeleteAllEntities();

            TodoTask todoTask1 = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            TodoTask todoTask2 = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            TodoTask todoTask3 = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            string response1 = taskController.CreateEntity(todoTask1);
            string response2 = taskController.CreateEntity(todoTask2);
            string response3 = taskController.CreateEntity(todoTask3);

            string expectedResponse = "OP_SUCCESS";
            Assert.AreEqual(expectedResponse, response1);
            Assert.AreEqual(expectedResponse, response2);
            Assert.AreEqual(expectedResponse, response3);
        }

        [TestMethod]
        public void Should_ReturnOpSucess_OnUpdateNewTask()
        {
            int correctId = 0;
            string correctPriority = "High";
            string correctTitle = "Test Task";
            DateTime correctCreationTime = DateTime.Now;
            string newCorrectPriority = "Medium";
            string newCorrectTitle = "Test Task Updated";
            DateTime newCorrectCreationTime = DateTime.Now;
            TodoTaskController taskController = new TodoTaskController();
            taskController.DeleteAllEntities();

            TodoTask todoTask = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            TodoTask updatedTodoTask = new TodoTask(1, newCorrectPriority, newCorrectTitle, newCorrectCreationTime);
            taskController.CreateEntity(todoTask);
            string response = taskController.UpdateEntity(updatedTodoTask);


            string expectedResponse = "OP_SUCCESS";
            Assert.AreEqual(expectedResponse, response);
        }

        [TestMethod]
        public void Should_ReturnOpSucess_OnUpdateInProgressTask()
        {
            int correctId = 0;
            string correctPriority = "High";
            string correctTitle = "Test Task";
            DateTime correctCreationTime = DateTime.Now;
            string newCorrectPriority = "Medium";
            string newCorrectTitle = "Test Task Updated";
            DateTime newCorrectCreationTime = DateTime.Now;
            TodoTaskController taskController = new TodoTaskController();
            taskController.DeleteAllEntities();

            TodoTask todoTask = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            TodoTask updatedTodoTask = new TodoTask(1, newCorrectPriority, newCorrectTitle, newCorrectCreationTime);
            updatedTodoTask.UpdatePercentageConcluded(50);
            taskController.CreateEntity(todoTask);
            string response = taskController.UpdateEntity(updatedTodoTask);


            string expectedResponse = "OP_SUCCESS";
            Assert.AreEqual(expectedResponse, response);
        }

        [TestMethod]
        public void Should_ReturnOpSucess_OnUpdateConcludedTask()
        {
            int correctId = 0;
            string correctPriority = "High";
            string correctTitle = "Test Task";
            DateTime correctCreationTime = DateTime.Now;
            string newCorrectPriority = "Medium";
            string newCorrectTitle = "Test Task Updated";
            DateTime newCorrectCreationTime = DateTime.Now;
            TodoTaskController taskController = new TodoTaskController();
            taskController.DeleteAllEntities();

            TodoTask todoTask = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            TodoTask updatedTodoTask = new TodoTask(1, newCorrectPriority, newCorrectTitle, newCorrectCreationTime);
            updatedTodoTask.UpdatePercentageConcluded(100);
            taskController.CreateEntity(todoTask);
            string response = taskController.UpdateEntity(updatedTodoTask);

            string expectedResponse = "OP_SUCCESS";
            Assert.AreEqual(expectedResponse, response);
        }

        [TestMethod]
        public void Should_ReturnFalse_OnExistEntityWithoutTodoTask()
        {
            int correctId = 0;
            string correctPriority = "High";
            string correctTitle = "Test Task";
            DateTime correctCreationTime = DateTime.Now;
            TodoTaskController taskController = new TodoTaskController();

            TodoTask todoTask = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            taskController.DeleteAllEntities();
            bool response = taskController.ExistEntity(todoTask.Id);

            Assert.IsFalse(response);
        }

        [TestMethod]
        public void Should_ReturnTrue_OnExistEntityWithOneTodoTask()
        {
            int correctId = 0;
            string correctPriority = "High";
            string correctTitle = "Test Task";
            DateTime correctCreationTime = DateTime.Now;
            TodoTaskController taskController = new TodoTaskController();

            TodoTask todoTask = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            taskController.DeleteAllEntities();
            taskController.CreateEntity(todoTask);
            bool response = taskController.ExistEntity(todoTask.Id);

            Assert.IsTrue(response);
        }

        [TestMethod]
        public void Should_ReturnTrue_OnExistEntityWithMultipleTodoTask()
        {
            int correctId = 0;
            string correctPriority = "High";
            string correctTitle = "Test Task";
            DateTime correctCreationTime = DateTime.Now;
            TodoTaskController taskController = new TodoTaskController();

            TodoTask todoTask1 = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            TodoTask todoTask2 = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            TodoTask todoTask3 = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            taskController.DeleteAllEntities();
            taskController.CreateEntity(todoTask1);
            taskController.CreateEntity(todoTask2);
            taskController.CreateEntity(todoTask3);
            bool response1 = taskController.ExistEntity(todoTask1.Id);
            bool response2 = taskController.ExistEntity(todoTask2.Id);
            bool response3 = taskController.ExistEntity(todoTask3.Id);

            Assert.IsTrue(response1);
            Assert.IsTrue(response2);
            Assert.IsTrue(response3);
        }
    }
}
