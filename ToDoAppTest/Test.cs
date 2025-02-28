using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ToDoAppTest
{
    [TestClass]
    public class ToDoAppTests
    {
        private static readonly string filePath = "test_todo_list.csv";

        // Setup: Lädt Aufgaben in eine Liste, um den Test isoliert zu machen
        [TestInitialize]
        public void Initialize()
        {
            // Sicherstellen, dass die Datei vor den Tests nicht existiert oder leer ist
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        [TestMethod]
        public void TestAddTask()
        {
            // Arrange
            var tasks = new List<string>();
            var task = "Neue Aufgabe";

            // Act
            tasks.Add(task);

            // Assert
            Assert.AreEqual(1, tasks.Count);
            Assert.AreEqual(task, tasks[0]);
        }

        [TestMethod]
        public void TestRemoveTask()
        {
            // Arrange
            var tasks = new List<string> { "Aufgabe 1", "Aufgabe 2", "Aufgabe 3" };
            var taskToRemove = "Aufgabe 2";

            // Act
            tasks.Remove(taskToRemove);

            // Assert
            Assert.AreEqual(2, tasks.Count);
            Assert.IsFalse(tasks.Contains(taskToRemove));
        }

        [TestMethod]
        public void TestSaveAndLoadTasks()
        {
            // Arrange
            var tasks = new List<string> { "Task 1", "Task 2", "Task 3" };

            // Act: Aufgaben speichern
            File.WriteAllLines(filePath, tasks);

            // Reload tasks
            var loadedTasks = File.ReadAllLines(filePath).ToList();

            // Assert
            Assert.AreEqual(tasks.Count, loadedTasks.Count);
            for (int i = 0; i < tasks.Count; i++)
            {
                Assert.AreEqual(tasks[i], loadedTasks[i]);
            }
        }

        [TestMethod]
        public void TestEmptyTaskList()
        {
            // Arrange
            var tasks = new List<string>();

            // Act
            bool isEmpty = !tasks.Any();

            // Assert
            Assert.IsTrue(isEmpty);
        }

        [TestMethod]
        public void TestInvalidRemoveTask()
        {
            // Arrange
            var tasks = new List<string> { "Aufgabe 1", "Aufgabe 2" };

            // Act & Assert
            bool result = tasks.Remove("Nicht existierende Aufgabe");
            Assert.IsFalse(result);
        }

        // Cleanup: Entfernt die Datei nach den Tests
        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}
