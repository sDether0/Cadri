using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadri.DataLayer.DataBase;
using Microsoft.EntityFrameworkCore;

namespace Cadri.UI.Forms
{
    public partial class TreeViewForm : Form
    {
        private static CadriDbContext cadri = new();
        public TreeViewForm()
        {
            InitializeComponent();
        }

        private void TreeView_Load(object sender, EventArgs e)
        {
            cadri.Employees.Load();
            cadri.Offices.Load();
            foreach (var office in cadri.Offices)
            {
                if (office.ParentId == null)
                {
                    var currentNode = treeView1.Nodes.Add(office.Id.ToString(), office.Name);
                    currentNode.NodeFont=new Font(FontFamily.GenericMonospace, 16f);
                    currentNode.BackColor = Color.Aquamarine;
                }
                else
                {
                    var currentNode = treeView1.Nodes.Find(office.ParentId.ToString(), true)[0]?.Nodes.Add(office.Id.ToString(),office.Name);
                    currentNode.NodeFont = new Font(FontFamily.GenericMonospace, 16f);
                    currentNode.BackColor = Color.Aquamarine;
                }
            }

            treeView1.Nodes.Add("-1","Бывшые сотрудники");
            foreach (var employee in cadri.Employees)
            {
                if (employee.CurrentOfficeId != null)
                {
                    var currentNode = treeView1.Nodes.Find(employee.CurrentOfficeId.ToString(), true)[0]?.Nodes
                        .Add(employee.Id.ToString(), employee.FIO);
                    currentNode.NodeFont = new Font(FontFamily.GenericSerif, 13f);
                    currentNode.BackColor = Color.AntiqueWhite;
                }
                else
                {
                    var currentNode = treeView1.Nodes["-1"].Nodes.Add(employee.Id.ToString(), employee.FIO);
                    currentNode.NodeFont = new Font(FontFamily.GenericSerif, 13f);
                    currentNode.BackColor = Color.AntiqueWhite;
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            var date = DateOnly.FromDateTime(dateTimePicker1.Value);
            foreach (var office in cadri.Offices)
            {
                if (office.ParentId == null)
                {
                    var currentNode = treeView1.Nodes.Add(office.Id.ToString(), office.Name);
                    currentNode.NodeFont = new Font(FontFamily.GenericMonospace, 16f);
                    currentNode.BackColor = Color.Aquamarine;
                    cadri.Employees.Where(x =>
                        cadri.TransfersInfo
                            .Where(x => x.OfficeId == office.Id && (date >= x.StartWork && (date <= x.EndWork || x.EndWork == null)))
                            .Select(x => x.EmployeeId).Contains(x.Id)).ForEachAsync(
                        x =>
                        {
                            currentNode.Nodes.Add(x.Id.ToString(), x.FIO);
                        });
                }
                else
                {
                    var currentNode = treeView1.Nodes.Find(office.ParentId.ToString(), true)[0]?.Nodes.Add(office.Id.ToString(), office.Name);
                    currentNode.NodeFont = new Font(FontFamily.GenericMonospace, 16f);
                    currentNode.BackColor = Color.Aquamarine;
                    cadri.Employees.Where(x =>
                        cadri.TransfersInfo
                            .Where(x => x.OfficeId == office.Id && (date >= x.StartWork && (date <= x.EndWork||x.EndWork==null)))
                            .Select(x => x.EmployeeId).Contains(x.Id)).ForEachAsync(
                        x =>
                        {
                            currentNode.Nodes.Add(x.Id.ToString(), x.FIO);
                        });
                }
            }
        }
    }
}
