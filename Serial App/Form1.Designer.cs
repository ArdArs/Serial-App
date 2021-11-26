
namespace Serial_App
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.serialConnect = new System.Windows.Forms.Button();
            this.refreshButt = new System.Windows.Forms.Button();
            this.speedLs = new System.Windows.Forms.ComboBox();
            this.ComLs = new System.Windows.Forms.ComboBox();
            this.exitButt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textLine = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.changeNL = new System.Windows.Forms.Button();
            this.nwLineVal = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lastInputStr = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.serialConnect, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.refreshButt, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.speedLs, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ComLs, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.73134F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.26866F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(266, 67);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // serialConnect
            // 
            this.serialConnect.Location = new System.Drawing.Point(3, 3);
            this.serialConnect.Name = "serialConnect";
            this.serialConnect.Size = new System.Drawing.Size(127, 29);
            this.serialConnect.TabIndex = 0;
            this.serialConnect.Text = "Connect";
            this.serialConnect.UseVisualStyleBackColor = true;
            this.serialConnect.Click += new System.EventHandler(this.serialConnect_Click);
            // 
            // refreshButt
            // 
            this.refreshButt.Location = new System.Drawing.Point(3, 38);
            this.refreshButt.Name = "refreshButt";
            this.refreshButt.Size = new System.Drawing.Size(127, 26);
            this.refreshButt.TabIndex = 3;
            this.refreshButt.Text = "Refresh";
            this.refreshButt.UseVisualStyleBackColor = true;
            this.refreshButt.Click += new System.EventHandler(this.refreshButt_Click);
            // 
            // speedLs
            // 
            this.speedLs.FormattingEnabled = true;
            this.speedLs.Items.AddRange(new object[] {
            "9600",
            "57600",
            "115200",
            "2000000"});
            this.speedLs.Location = new System.Drawing.Point(136, 38);
            this.speedLs.Name = "speedLs";
            this.speedLs.Size = new System.Drawing.Size(127, 21);
            this.speedLs.TabIndex = 2;
            this.speedLs.Text = "Serial speed";
            this.speedLs.SelectedIndexChanged += new System.EventHandler(this.baudrateChanged);
            // 
            // ComLs
            // 
            this.ComLs.FormattingEnabled = true;
            this.ComLs.Location = new System.Drawing.Point(136, 3);
            this.ComLs.Name = "ComLs";
            this.ComLs.Size = new System.Drawing.Size(127, 21);
            this.ComLs.TabIndex = 1;
            this.ComLs.Text = "COM list";
            this.ComLs.SelectedIndexChanged += new System.EventHandler(this.indexChanged);
            // 
            // exitButt
            // 
            this.exitButt.Location = new System.Drawing.Point(5, 275);
            this.exitButt.Name = "exitButt";
            this.exitButt.Size = new System.Drawing.Size(75, 23);
            this.exitButt.TabIndex = 1;
            this.exitButt.Text = "exit";
            this.exitButt.UseVisualStyleBackColor = true;
            this.exitButt.Click += new System.EventHandler(this.exitButtClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Serial control";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.sendbuttonClick);
            // 
            // textLine
            // 
            this.textLine.Location = new System.Drawing.Point(3, 3);
            this.textLine.Name = "textLine";
            this.textLine.Size = new System.Drawing.Size(148, 20);
            this.textLine.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.93536F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.06464F));
            this.tableLayoutPanel2.Controls.Add(this.checkBox1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.checkBox2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textLine, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 143);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(263, 80);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(34, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "\\r";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(3, 33);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(37, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "\\n";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "new line";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "carriage return"
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.changeNL, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.nwLineVal, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(373, 29);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.4375F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.5625F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 64);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 0;
            // 
            // changeNL
            // 
            this.changeNL.Location = new System.Drawing.Point(137, 3);
            this.changeNL.Name = "changeNL";
            this.changeNL.Size = new System.Drawing.Size(60, 21);
            this.changeNL.TabIndex = 1;
            this.changeNL.Text = "Change";
            this.changeNL.UseVisualStyleBackColor = true;
            this.changeNL.Click += new System.EventHandler(this.changeNL_Click);
            // 
            // nwLineVal
            // 
            this.nwLineVal.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nwLineVal.FormattingEnabled = true;
            this.nwLineVal.Items.AddRange(new object[] {
            "\\n",
            "\\r",
            "\\n\\r",
            ";"});
            this.nwLineVal.Location = new System.Drawing.Point(3, 34);
            this.nwLineVal.Name = "nwLineVal";
            this.nwLineVal.Size = new System.Drawing.Size(127, 24);
            this.nwLineVal.TabIndex = 2;
            this.nwLineVal.Text = "character newline";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "Standard characters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Input settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Output settings";
            // 
            // lastInputStr
            // 
            this.lastInputStr.AutoSize = true;
            this.lastInputStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastInputStr.Location = new System.Drawing.Point(371, 146);
            this.lastInputStr.Name = "lastInputStr";
            this.lastInputStr.Size = new System.Drawing.Size(0, 26);
            this.lastInputStr.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 310);
            this.Controls.Add(this.lastInputStr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButt);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button serialConnect;
        private System.Windows.Forms.ComboBox ComLs;
        private System.Windows.Forms.ComboBox speedLs;
        private System.Windows.Forms.Button refreshButt;
        private System.Windows.Forms.Button exitButt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textLine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button changeNL;
        private System.Windows.Forms.ComboBox nwLineVal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lastInputStr;
    }
}

