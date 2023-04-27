﻿namespace Lienzos
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reingresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.Clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Productos = new System.Windows.Forms.ToolStripMenuItem();
            this.Tipo_Productos = new System.Windows.Forms.ToolStripMenuItem();
            this.Procesos = new System.Windows.Forms.ToolStripMenuItem();
            this.Venta = new System.Windows.Forms.ToolStripMenuItem();
            this.Devolucion = new System.Windows.Forms.ToolStripMenuItem();
            this.Reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.Reporte_Venta = new System.Windows.Forms.ToolStripMenuItem();
            this.Reporte_Cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.Reporte_Producto = new System.Windows.Forms.ToolStripMenuItem();
            this.Seguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.Roles = new System.Windows.Forms.ToolStripMenuItem();
            this.Bitacora_Ingresos = new System.Windows.Forms.ToolStripMenuItem();
            this.Bitacora_Movimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Txt_Usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.Mantenimientos,
            this.Procesos,
            this.Reportes,
            this.Seguridad,
            this.Salir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reingresarToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // reingresarToolStripMenuItem
            // 
            this.reingresarToolStripMenuItem.Name = "reingresarToolStripMenuItem";
            this.reingresarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reingresarToolStripMenuItem.Text = "Reingresar";
            this.reingresarToolStripMenuItem.Click += new System.EventHandler(this.reingresarToolStripMenuItem_Click);
            // 
            // Mantenimientos
            // 
            this.Mantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Clientes,
            this.Productos,
            this.Tipo_Productos});
            this.Mantenimientos.Name = "Mantenimientos";
            this.Mantenimientos.Size = new System.Drawing.Size(106, 20);
            this.Mantenimientos.Text = "Mantenimientos";
            // 
            // Clientes
            // 
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(175, 22);
            this.Clientes.Text = "Clientes";
            // 
            // Productos
            // 
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(175, 22);
            this.Productos.Text = "Productos";
            // 
            // Tipo_Productos
            // 
            this.Tipo_Productos.Name = "Tipo_Productos";
            this.Tipo_Productos.Size = new System.Drawing.Size(175, 22);
            this.Tipo_Productos.Text = "Tipos de Productos";
            // 
            // Procesos
            // 
            this.Procesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Venta,
            this.Devolucion});
            this.Procesos.Name = "Procesos";
            this.Procesos.Size = new System.Drawing.Size(66, 20);
            this.Procesos.Text = "Procesos";
            // 
            // Venta
            // 
            this.Venta.Name = "Venta";
            this.Venta.Size = new System.Drawing.Size(194, 22);
            this.Venta.Text = "Proceso de venta";
            // 
            // Devolucion
            // 
            this.Devolucion.Name = "Devolucion";
            this.Devolucion.Size = new System.Drawing.Size(194, 22);
            this.Devolucion.Text = "Proceso de devolucion";
            // 
            // Reportes
            // 
            this.Reportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Reporte_Venta,
            this.Reporte_Cliente,
            this.Reporte_Producto});
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(65, 20);
            this.Reportes.Text = "Reportes";
            // 
            // Reporte_Venta
            // 
            this.Reporte_Venta.Name = "Reporte_Venta";
            this.Reporte_Venta.Size = new System.Drawing.Size(188, 22);
            this.Reporte_Venta.Text = "Reporte de venta";
            // 
            // Reporte_Cliente
            // 
            this.Reporte_Cliente.Name = "Reporte_Cliente";
            this.Reporte_Cliente.Size = new System.Drawing.Size(188, 22);
            this.Reporte_Cliente.Text = "Reporte de clientes";
            // 
            // Reporte_Producto
            // 
            this.Reporte_Producto.Name = "Reporte_Producto";
            this.Reporte_Producto.Size = new System.Drawing.Size(188, 22);
            this.Reporte_Producto.Text = "Reporte de productos";
            // 
            // Seguridad
            // 
            this.Seguridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Usuarios,
            this.Roles,
            this.Bitacora_Ingresos,
            this.Bitacora_Movimientos});
            this.Seguridad.Name = "Seguridad";
            this.Seguridad.Size = new System.Drawing.Size(72, 20);
            this.Seguridad.Text = "Seguridad";
            // 
            // Usuarios
            // 
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(227, 22);
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.Click += new System.EventHandler(this.Usuarios_Click);
            // 
            // Roles
            // 
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(227, 22);
            this.Roles.Text = "Roles";
            this.Roles.Click += new System.EventHandler(this.Roles_Click);
            // 
            // Bitacora_Ingresos
            // 
            this.Bitacora_Ingresos.Name = "Bitacora_Ingresos";
            this.Bitacora_Ingresos.Size = new System.Drawing.Size(227, 22);
            this.Bitacora_Ingresos.Text = "Bitacora de ingresos y salidas";
            // 
            // Bitacora_Movimientos
            // 
            this.Bitacora_Movimientos.Name = "Bitacora_Movimientos";
            this.Bitacora_Movimientos.Size = new System.Drawing.Size(227, 22);
            this.Bitacora_Movimientos.Text = "Bitacora de movimientos";
            // 
            // Salir
            // 
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(41, 20);
            this.Salir.Text = "Salir";
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Txt_Usuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(0, 17);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Txt_Usuario;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Mantenimientos;
        private System.Windows.Forms.ToolStripMenuItem Clientes;
        private System.Windows.Forms.ToolStripMenuItem Productos;
        private System.Windows.Forms.ToolStripMenuItem Tipo_Productos;
        private System.Windows.Forms.ToolStripMenuItem Procesos;
        private System.Windows.Forms.ToolStripMenuItem Venta;
        private System.Windows.Forms.ToolStripMenuItem Devolucion;
        private System.Windows.Forms.ToolStripMenuItem Reportes;
        private System.Windows.Forms.ToolStripMenuItem Seguridad;
        private System.Windows.Forms.ToolStripMenuItem Salir;
        private System.Windows.Forms.ToolStripMenuItem Reporte_Venta;
        private System.Windows.Forms.ToolStripMenuItem Reporte_Cliente;
        private System.Windows.Forms.ToolStripMenuItem Reporte_Producto;
        private System.Windows.Forms.ToolStripMenuItem Usuarios;
        private System.Windows.Forms.ToolStripMenuItem Roles;
        private System.Windows.Forms.ToolStripMenuItem Bitacora_Ingresos;
        private System.Windows.Forms.ToolStripMenuItem Bitacora_Movimientos;
        private System.Windows.Forms.ToolStripMenuItem reingresarToolStripMenuItem;
    }
}