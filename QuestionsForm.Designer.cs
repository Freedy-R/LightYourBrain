namespace LightYourBrain
{
    partial class QuestionsForm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionsForm_main));
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.restartGame = new System.Windows.Forms.Button();
            this.mute = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.buttonAnsw3 = new System.Windows.Forms.Button();
            this.buttonAnsw1 = new System.Windows.Forms.Button();
            this.buttonAnsw4 = new System.Windows.Forms.Button();
            this.buttonAnsw2 = new System.Windows.Forms.Button();
            this.QuestionLayout = new System.Windows.Forms.TableLayoutPanel();
            this.QuestionLayout_Left = new System.Windows.Forms.TableLayoutPanel();
            this.QuestionLayout_main = new System.Windows.Forms.TableLayoutPanel();
            this.QuestionLayout_Answers = new System.Windows.Forms.TableLayoutPanel();
            this.QuestionLayout.SuspendLayout();
            this.QuestionLayout_Left.SuspendLayout();
            this.QuestionLayout_main.SuspendLayout();
            this.QuestionLayout_Answers.SuspendLayout();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreLabel.Location = new System.Drawing.Point(0, 0);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(300, 102);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Your score: ";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scoreLabel.Click += new System.EventHandler(this.scoreLabel_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label2.Location = new System.Drawing.Point(0, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 102);
            this.label2.TabIndex = 2;
            this.label2.Text = "Avaible lifesavers";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(178)))), ((int)(((byte)(54)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(10, 316);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "50/50";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(178)))), ((int)(((byte)(54)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button2.Location = new System.Drawing.Point(10, 418);
            this.button2.Margin = new System.Windows.Forms.Padding(10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 82);
            this.button2.TabIndex = 0;
            this.button2.Text = "omit question";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // restartGame
            // 
            this.restartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(178)))), ((int)(((byte)(54)))));
            this.restartGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.restartGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.restartGame.Location = new System.Drawing.Point(10, 622);
            this.restartGame.Margin = new System.Windows.Forms.Padding(10);
            this.restartGame.Name = "restartGame";
            this.restartGame.Size = new System.Drawing.Size(280, 82);
            this.restartGame.TabIndex = 1;
            this.restartGame.Text = "Restart game";
            this.restartGame.UseVisualStyleBackColor = false;
            // 
            // mute
            // 
            this.mute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(178)))), ((int)(((byte)(54)))));
            this.mute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mute.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.mute.Location = new System.Drawing.Point(10, 724);
            this.mute.Margin = new System.Windows.Forms.Padding(10);
            this.mute.Name = "mute";
            this.mute.Size = new System.Drawing.Size(280, 83);
            this.mute.TabIndex = 0;
            this.mute.Text = "Mute music";
            this.mute.UseVisualStyleBackColor = false;
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(140)))));
            this.questionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionLabel.Location = new System.Drawing.Point(0, 0);
            this.questionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Padding = new System.Windows.Forms.Padding(7);
            this.questionLabel.Size = new System.Drawing.Size(1201, 408);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor in" +
    "cididunt ut labore et dolore magna aliqua.";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.questionLabel.Click += new System.EventHandler(this.questionLabel_Click);
            // 
            // buttonAnsw3
            // 
            this.buttonAnsw3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(178)))), ((int)(((byte)(54)))));
            this.buttonAnsw3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAnsw3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAnsw3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAnsw3.Location = new System.Drawing.Point(12, 215);
            this.buttonAnsw3.Margin = new System.Windows.Forms.Padding(10);
            this.buttonAnsw3.Name = "buttonAnsw3";
            this.buttonAnsw3.Size = new System.Drawing.Size(577, 182);
            this.buttonAnsw3.TabIndex = 0;
            this.buttonAnsw3.Text = "C";
            this.buttonAnsw3.UseVisualStyleBackColor = false;
            this.buttonAnsw3.Click += new System.EventHandler(this.buttonAnsw3_Click);
            // 
            // buttonAnsw1
            // 
            this.buttonAnsw1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(178)))), ((int)(((byte)(54)))));
            this.buttonAnsw1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAnsw1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAnsw1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAnsw1.Location = new System.Drawing.Point(12, 12);
            this.buttonAnsw1.Margin = new System.Windows.Forms.Padding(10);
            this.buttonAnsw1.Name = "buttonAnsw1";
            this.buttonAnsw1.Size = new System.Drawing.Size(577, 181);
            this.buttonAnsw1.TabIndex = 0;
            this.buttonAnsw1.Text = "A";
            this.buttonAnsw1.UseVisualStyleBackColor = false;
            this.buttonAnsw1.Click += new System.EventHandler(this.buttonAnsw1_Click);
            // 
            // buttonAnsw4
            // 
            this.buttonAnsw4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(178)))), ((int)(((byte)(54)))));
            this.buttonAnsw4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAnsw4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAnsw4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAnsw4.Location = new System.Drawing.Point(611, 215);
            this.buttonAnsw4.Margin = new System.Windows.Forms.Padding(10);
            this.buttonAnsw4.Name = "buttonAnsw4";
            this.buttonAnsw4.Size = new System.Drawing.Size(578, 182);
            this.buttonAnsw4.TabIndex = 0;
            this.buttonAnsw4.Text = "D";
            this.buttonAnsw4.UseVisualStyleBackColor = false;
            this.buttonAnsw4.Click += new System.EventHandler(this.buttonAnsw4_Click);
            // 
            // buttonAnsw2
            // 
            this.buttonAnsw2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(178)))), ((int)(((byte)(54)))));
            this.buttonAnsw2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAnsw2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAnsw2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAnsw2.Location = new System.Drawing.Point(611, 12);
            this.buttonAnsw2.Margin = new System.Windows.Forms.Padding(10);
            this.buttonAnsw2.Name = "buttonAnsw2";
            this.buttonAnsw2.Size = new System.Drawing.Size(578, 181);
            this.buttonAnsw2.TabIndex = 0;
            this.buttonAnsw2.Text = "B";
            this.buttonAnsw2.UseVisualStyleBackColor = false;
            this.buttonAnsw2.Click += new System.EventHandler(this.buttonAnsw2_Click);
            // 
            // QuestionLayout
            // 
            this.QuestionLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.QuestionLayout.ColumnCount = 2;
            this.QuestionLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.QuestionLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.QuestionLayout.Controls.Add(this.QuestionLayout_Left, 0, 0);
            this.QuestionLayout.Controls.Add(this.QuestionLayout_main, 1, 0);
            this.QuestionLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.QuestionLayout.Location = new System.Drawing.Point(0, 0);
            this.QuestionLayout.Margin = new System.Windows.Forms.Padding(0);
            this.QuestionLayout.Name = "QuestionLayout";
            this.QuestionLayout.RowCount = 1;
            this.QuestionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.QuestionLayout.Size = new System.Drawing.Size(1507, 821);
            this.QuestionLayout.TabIndex = 3;
            // 
            // QuestionLayout_Left
            // 
            this.QuestionLayout_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(225)))), ((int)(((byte)(97)))));
            this.QuestionLayout_Left.ColumnCount = 1;
            this.QuestionLayout_Left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.QuestionLayout_Left.Controls.Add(this.label2, 0, 2);
            this.QuestionLayout_Left.Controls.Add(this.button1, 0, 3);
            this.QuestionLayout_Left.Controls.Add(this.button2, 0, 4);
            this.QuestionLayout_Left.Controls.Add(this.scoreLabel, 0, 0);
            this.QuestionLayout_Left.Controls.Add(this.mute, 0, 7);
            this.QuestionLayout_Left.Controls.Add(this.restartGame, 0, 6);
            this.QuestionLayout_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionLayout_Left.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.QuestionLayout_Left.Location = new System.Drawing.Point(2, 2);
            this.QuestionLayout_Left.Margin = new System.Windows.Forms.Padding(0);
            this.QuestionLayout_Left.Name = "QuestionLayout_Left";
            this.QuestionLayout_Left.RowCount = 8;
            this.QuestionLayout_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.QuestionLayout_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.QuestionLayout_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.QuestionLayout_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.QuestionLayout_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.QuestionLayout_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.QuestionLayout_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.QuestionLayout_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.QuestionLayout_Left.Size = new System.Drawing.Size(300, 817);
            this.QuestionLayout_Left.TabIndex = 0;
            // 
            // QuestionLayout_main
            // 
            this.QuestionLayout_main.ColumnCount = 1;
            this.QuestionLayout_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.QuestionLayout_main.Controls.Add(this.QuestionLayout_Answers, 0, 1);
            this.QuestionLayout_main.Controls.Add(this.questionLabel, 0, 0);
            this.QuestionLayout_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionLayout_main.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.QuestionLayout_main.Location = new System.Drawing.Point(304, 2);
            this.QuestionLayout_main.Margin = new System.Windows.Forms.Padding(0);
            this.QuestionLayout_main.Name = "QuestionLayout_main";
            this.QuestionLayout_main.RowCount = 2;
            this.QuestionLayout_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.QuestionLayout_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.QuestionLayout_main.Size = new System.Drawing.Size(1201, 817);
            this.QuestionLayout_main.TabIndex = 4;
            // 
            // QuestionLayout_Answers
            // 
            this.QuestionLayout_Answers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(140)))));
            this.QuestionLayout_Answers.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.QuestionLayout_Answers.ColumnCount = 2;
            this.QuestionLayout_Answers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.QuestionLayout_Answers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.QuestionLayout_Answers.Controls.Add(this.buttonAnsw1, 0, 0);
            this.QuestionLayout_Answers.Controls.Add(this.buttonAnsw2, 1, 0);
            this.QuestionLayout_Answers.Controls.Add(this.buttonAnsw4, 1, 1);
            this.QuestionLayout_Answers.Controls.Add(this.buttonAnsw3, 0, 1);
            this.QuestionLayout_Answers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionLayout_Answers.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.QuestionLayout_Answers.Location = new System.Drawing.Point(0, 408);
            this.QuestionLayout_Answers.Margin = new System.Windows.Forms.Padding(0);
            this.QuestionLayout_Answers.Name = "QuestionLayout_Answers";
            this.QuestionLayout_Answers.RowCount = 2;
            this.QuestionLayout_Answers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.QuestionLayout_Answers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.QuestionLayout_Answers.Size = new System.Drawing.Size(1201, 409);
            this.QuestionLayout_Answers.TabIndex = 4;
            // 
            // QuestionsForm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 821);
            this.Controls.Add(this.QuestionLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuestionsForm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuestionsForm";
            this.Load += new System.EventHandler(this.QuestionsForm_Load);
            this.QuestionLayout.ResumeLayout(false);
            this.QuestionLayout_Left.ResumeLayout(false);
            this.QuestionLayout_main.ResumeLayout(false);
            this.QuestionLayout_Answers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button restartGame;
        private System.Windows.Forms.Button mute;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button buttonAnsw3;
        private System.Windows.Forms.Button buttonAnsw1;
        private System.Windows.Forms.Button buttonAnsw4;
        private System.Windows.Forms.Button buttonAnsw2;
        private System.Windows.Forms.TableLayoutPanel QuestionLayout;
        private System.Windows.Forms.TableLayoutPanel QuestionLayout_Left;
        private System.Windows.Forms.TableLayoutPanel QuestionLayout_main;
        private System.Windows.Forms.TableLayoutPanel QuestionLayout_Answers;
    }
}