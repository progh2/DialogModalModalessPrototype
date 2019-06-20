namespace DialogModalModaless
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmsForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ModalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModalessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다이어로그ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모달창열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모달리스ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이프로그램은ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModal = new System.Windows.Forms.Button();
            this.btnModaless = new System.Windows.Forms.Button();
            this.cmsForm.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsForm
            // 
            this.cmsForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModalToolStripMenuItem,
            this.ModalessToolStripMenuItem});
            this.cmsForm.Name = "cmsForm";
            this.cmsForm.Size = new System.Drawing.Size(175, 48);
            // 
            // ModalToolStripMenuItem
            // 
            this.ModalToolStripMenuItem.Name = "ModalToolStripMenuItem";
            this.ModalToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ModalToolStripMenuItem.Text = "모달창 띄우기";
            // 
            // ModalessToolStripMenuItem
            // 
            this.ModalessToolStripMenuItem.Name = "ModalessToolStripMenuItem";
            this.ModalessToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ModalessToolStripMenuItem.Text = "모달리스창 띄우기";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 178);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(431, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(272, 17);
            this.toolStripStatusLabel1.Text = "다이어로그 - Modal vs. Modaless by 3OOO OOO";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.다이어로그ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(431, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // 다이어로그ToolStripMenuItem
            // 
            this.다이어로그ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.모달창열기ToolStripMenuItem,
            this.모달리스ToolStripMenuItem});
            this.다이어로그ToolStripMenuItem.Name = "다이어로그ToolStripMenuItem";
            this.다이어로그ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.다이어로그ToolStripMenuItem.Text = "다이어로그";
            // 
            // 모달창열기ToolStripMenuItem
            // 
            this.모달창열기ToolStripMenuItem.Name = "모달창열기ToolStripMenuItem";
            this.모달창열기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.모달창열기ToolStripMenuItem.Text = "모달";
            this.모달창열기ToolStripMenuItem.Click += new System.EventHandler(this.모달창열기ToolStripMenuItem_Click);
            // 
            // 모달리스ToolStripMenuItem
            // 
            this.모달리스ToolStripMenuItem.Name = "모달리스ToolStripMenuItem";
            this.모달리스ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.모달리스ToolStripMenuItem.Text = "모달리스";
            this.모달리스ToolStripMenuItem.Click += new System.EventHandler(this.모달리스ToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.이프로그램은ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // 이프로그램은ToolStripMenuItem
            // 
            this.이프로그램은ToolStripMenuItem.Name = "이프로그램은ToolStripMenuItem";
            this.이프로그램은ToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.이프로그램은ToolStripMenuItem.Text = "이 프로그램은...";
            // 
            // btnModal
            // 
            this.btnModal.Location = new System.Drawing.Point(12, 27);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(200, 130);
            this.btnModal.TabIndex = 3;
            this.btnModal.Text = "Modal";
            this.btnModal.UseVisualStyleBackColor = true;
            this.btnModal.Click += new System.EventHandler(this.BtnModal_Click);
            // 
            // btnModaless
            // 
            this.btnModaless.Location = new System.Drawing.Point(218, 27);
            this.btnModaless.Name = "btnModaless";
            this.btnModaless.Size = new System.Drawing.Size(200, 130);
            this.btnModaless.TabIndex = 4;
            this.btnModaless.Text = "Modaless";
            this.btnModaless.UseVisualStyleBackColor = true;
            this.btnModaless.Click += new System.EventHandler(this.BtnModaless_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 200);
            this.Controls.Add(this.btnModaless);
            this.Controls.Add(this.btnModal);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "다이어로그 - Modal vs. Modaless by 3OOO OOO";
            this.cmsForm.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsForm;
        private System.Windows.Forms.ToolStripMenuItem ModalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModalessToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다이어로그ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모달창열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모달리스ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이프로그램은ToolStripMenuItem;
        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.Button btnModaless;
    }
}

