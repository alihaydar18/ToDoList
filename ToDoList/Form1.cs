using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        private List<ToDoItem> todoList = new List<ToDoItem>();
        private int nextId = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Baþlýk boþ olamaz.");
                return;
            }

            ToDoItem newItem = new ToDoItem
            {
                Id = nextId++,
                Title = title,
                IsCompleted = false
            };

            todoList.Add(newItem);
            RefreshToDoList();
            textBox1.Clear();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems == null)
            {
                MessageBox.Show("Choose a element for delete ");
                return;
            }
            ToDoItem selectedItem = (ToDoItem)listBox1.SelectedItem;
            todoList.Remove(selectedItem);
            RefreshToDoList();
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems == null)
            {
                MessageBox.Show("Choose a element for edit");
                return;
            }
            ToDoItem selectedItem = (ToDoItem)listBox1.SelectedItem;
            selectedItem.Title = textBox1.Text;
            RefreshToDoList();
        }
        private void listbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                ToDoItem selectedItem = (ToDoItem)listBox1.SelectedItem;
                textBox1.Text = selectedItem.Title;
            }
        }
        
        private void button4_Click_1(object sender, EventArgs e)
        {
            {
                if (listBox1.SelectedItem == null)
                {
                    MessageBox.Show("Durumu deðiþtirmek için bir öðe seçin.");
                    return;
                }

                ToDoItem selectedItem = (ToDoItem)listBox1.SelectedItem;
                selectedItem.IsCompleted = !selectedItem.IsCompleted;
                RefreshToDoList();
            }
        }
        private void RefreshToDoList()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = todoList;
        }
    }
}