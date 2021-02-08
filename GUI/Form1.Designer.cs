namespace GUI {
    partial class Form1 {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent() {
            this.aButton = new System.Windows.Forms.Button();
            this.eButton = new System.Windows.Forms.Button();
            this.gButton = new System.Windows.Forms.Button();
            this.bButton = new System.Windows.Forms.Button();
            this.fButton = new System.Windows.Forms.Button();
            this.extraSetsButton = new System.Windows.Forms.Button();
            this.leftparButton = new System.Windows.Forms.Button();
            this.complementButton = new System.Windows.Forms.Button();
            this.emptysetButton = new System.Windows.Forms.Button();
            this.rightparButton = new System.Windows.Forms.Button();
            this.differenceButton = new System.Windows.Forms.Button();
            this.intersectionButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.neginclusionButton = new System.Windows.Forms.Button();
            this.inclusionButton = new System.Windows.Forms.Button();
            this.equalityButton = new System.Windows.Forms.Button();
            this.backspaceButton = new System.Windows.Forms.Button();
            this.sharpneginclusionButton = new System.Windows.Forms.Button();
            this.sharpinclusionButton = new System.Windows.Forms.Button();
            this.parseButton = new System.Windows.Forms.Button();
            this.textDisplay = new System.Windows.Forms.TextBox();
            this.unionButton = new System.Windows.Forms.Button();
            this.implicationButton = new System.Windows.Forms.Button();
            this.dButton = new System.Windows.Forms.Button();
            this.cButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aButton
            // 
            this.aButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aButton.Location = new System.Drawing.Point(3, 2);
            this.aButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aButton.Name = "aButton";
            this.aButton.Size = new System.Drawing.Size(64, 56);
            this.aButton.TabIndex = 0;
            this.aButton.Text = "A";
            this.aButton.UseVisualStyleBackColor = true;
            this.aButton.Click += new System.EventHandler(this.setSign);
            // 
            // eButton
            // 
            this.eButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eButton.Location = new System.Drawing.Point(3, 122);
            this.eButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eButton.Name = "eButton";
            this.eButton.Size = new System.Drawing.Size(64, 56);
            this.eButton.TabIndex = 0;
            this.eButton.Text = "E";
            this.eButton.UseVisualStyleBackColor = true;
            this.eButton.Click += new System.EventHandler(this.setSign);
            // 
            // gButton
            // 
            this.gButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gButton.Location = new System.Drawing.Point(3, 182);
            this.gButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gButton.Name = "gButton";
            this.gButton.Size = new System.Drawing.Size(64, 58);
            this.gButton.TabIndex = 0;
            this.gButton.Text = "G";
            this.gButton.UseVisualStyleBackColor = true;
            this.gButton.Click += new System.EventHandler(this.setSign);
            // 
            // bButton
            // 
            this.bButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bButton.Location = new System.Drawing.Point(73, 2);
            this.bButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bButton.Name = "bButton";
            this.bButton.Size = new System.Drawing.Size(64, 56);
            this.bButton.TabIndex = 0;
            this.bButton.Text = "B";
            this.bButton.UseVisualStyleBackColor = true;
            this.bButton.Click += new System.EventHandler(this.setSign);
            // 
            // fButton
            // 
            this.fButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fButton.Location = new System.Drawing.Point(73, 122);
            this.fButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fButton.Name = "fButton";
            this.fButton.Size = new System.Drawing.Size(64, 56);
            this.fButton.TabIndex = 0;
            this.fButton.Text = "F";
            this.fButton.UseVisualStyleBackColor = true;
            this.fButton.Click += new System.EventHandler(this.setSign);
            // 
            // extraSetsButton
            // 
            this.extraSetsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extraSetsButton.Enabled = false;
            this.extraSetsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.extraSetsButton.Location = new System.Drawing.Point(73, 182);
            this.extraSetsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.extraSetsButton.Name = "extraSetsButton";
            this.extraSetsButton.Size = new System.Drawing.Size(64, 58);
            this.extraSetsButton.TabIndex = 0;
            this.extraSetsButton.Text = "...";
            this.extraSetsButton.UseVisualStyleBackColor = true;
            this.extraSetsButton.Click += new System.EventHandler(this.setSign);
            // 
            // leftparButton
            // 
            this.leftparButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftparButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftparButton.Location = new System.Drawing.Point(143, 2);
            this.leftparButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftparButton.Name = "leftparButton";
            this.leftparButton.Size = new System.Drawing.Size(64, 56);
            this.leftparButton.TabIndex = 0;
            this.leftparButton.Text = "button1";
            this.leftparButton.UseVisualStyleBackColor = true;
            this.leftparButton.Click += new System.EventHandler(this.leftparSign);
            // 
            // complementButton
            // 
            this.complementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.complementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.complementButton.Location = new System.Drawing.Point(143, 122);
            this.complementButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.complementButton.Name = "complementButton";
            this.complementButton.Size = new System.Drawing.Size(64, 56);
            this.complementButton.TabIndex = 0;
            this.complementButton.Text = "button1";
            this.complementButton.UseVisualStyleBackColor = true;
            this.complementButton.Click += new System.EventHandler(this.complementSign);
            // 
            // emptysetButton
            // 
            this.emptysetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emptysetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emptysetButton.Location = new System.Drawing.Point(143, 182);
            this.emptysetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emptysetButton.Name = "emptysetButton";
            this.emptysetButton.Size = new System.Drawing.Size(64, 58);
            this.emptysetButton.TabIndex = 0;
            this.emptysetButton.Text = "button1";
            this.emptysetButton.UseVisualStyleBackColor = true;
            this.emptysetButton.Click += new System.EventHandler(this.setSign);
            // 
            // rightparButton
            // 
            this.rightparButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightparButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rightparButton.Location = new System.Drawing.Point(213, 2);
            this.rightparButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightparButton.Name = "rightparButton";
            this.rightparButton.Size = new System.Drawing.Size(64, 56);
            this.rightparButton.TabIndex = 0;
            this.rightparButton.Text = "button1";
            this.rightparButton.UseVisualStyleBackColor = true;
            this.rightparButton.Click += new System.EventHandler(this.rightparSign);
            // 
            // differenceButton
            // 
            this.differenceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.differenceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.differenceButton.Location = new System.Drawing.Point(213, 122);
            this.differenceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.differenceButton.Name = "differenceButton";
            this.differenceButton.Size = new System.Drawing.Size(64, 56);
            this.differenceButton.TabIndex = 0;
            this.differenceButton.Text = "button1";
            this.differenceButton.UseVisualStyleBackColor = true;
            this.differenceButton.Click += new System.EventHandler(this.operationSign);
            // 
            // intersectionButton
            // 
            this.intersectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.intersectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.intersectionButton.Location = new System.Drawing.Point(143, 62);
            this.intersectionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.intersectionButton.Name = "intersectionButton";
            this.intersectionButton.Size = new System.Drawing.Size(64, 56);
            this.intersectionButton.TabIndex = 0;
            this.intersectionButton.Text = "button1";
            this.intersectionButton.UseVisualStyleBackColor = true;
            this.intersectionButton.Click += new System.EventHandler(this.operationSign);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(283, 2);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(64, 56);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "button1";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // neginclusionButton
            // 
            this.neginclusionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.neginclusionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.neginclusionButton.Location = new System.Drawing.Point(283, 122);
            this.neginclusionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.neginclusionButton.Name = "neginclusionButton";
            this.neginclusionButton.Size = new System.Drawing.Size(64, 56);
            this.neginclusionButton.TabIndex = 0;
            this.neginclusionButton.Text = "button1";
            this.neginclusionButton.UseVisualStyleBackColor = true;
            this.neginclusionButton.Click += new System.EventHandler(this.operationSign);
            // 
            // inclusionButton
            // 
            this.inclusionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inclusionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inclusionButton.Location = new System.Drawing.Point(283, 62);
            this.inclusionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inclusionButton.Name = "inclusionButton";
            this.inclusionButton.Size = new System.Drawing.Size(64, 56);
            this.inclusionButton.TabIndex = 0;
            this.inclusionButton.Text = "button1";
            this.inclusionButton.UseVisualStyleBackColor = true;
            this.inclusionButton.Click += new System.EventHandler(this.operationSign);
            // 
            // equalityButton
            // 
            this.equalityButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equalityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equalityButton.Location = new System.Drawing.Point(283, 182);
            this.equalityButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.equalityButton.Name = "equalityButton";
            this.equalityButton.Size = new System.Drawing.Size(64, 58);
            this.equalityButton.TabIndex = 0;
            this.equalityButton.Text = "button1";
            this.equalityButton.UseVisualStyleBackColor = true;
            this.equalityButton.Click += new System.EventHandler(this.operationSign);
            // 
            // backspaceButton
            // 
            this.backspaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backspaceButton.Location = new System.Drawing.Point(353, 2);
            this.backspaceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backspaceButton.Name = "backspaceButton";
            this.backspaceButton.Size = new System.Drawing.Size(70, 56);
            this.backspaceButton.TabIndex = 0;
            this.backspaceButton.UseVisualStyleBackColor = true;
            this.backspaceButton.Click += new System.EventHandler(this.backspaceButton_Click);
            // 
            // sharpneginclusionButton
            // 
            this.sharpneginclusionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sharpneginclusionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sharpneginclusionButton.Location = new System.Drawing.Point(353, 122);
            this.sharpneginclusionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sharpneginclusionButton.Name = "sharpneginclusionButton";
            this.sharpneginclusionButton.Size = new System.Drawing.Size(70, 56);
            this.sharpneginclusionButton.TabIndex = 0;
            this.sharpneginclusionButton.Text = "button1";
            this.sharpneginclusionButton.UseVisualStyleBackColor = true;
            this.sharpneginclusionButton.Click += new System.EventHandler(this.operationSign);
            // 
            // sharpinclusionButton
            // 
            this.sharpinclusionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sharpinclusionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sharpinclusionButton.Location = new System.Drawing.Point(353, 62);
            this.sharpinclusionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sharpinclusionButton.Name = "sharpinclusionButton";
            this.sharpinclusionButton.Size = new System.Drawing.Size(70, 56);
            this.sharpinclusionButton.TabIndex = 0;
            this.sharpinclusionButton.Text = "button1";
            this.sharpinclusionButton.UseVisualStyleBackColor = true;
            this.sharpinclusionButton.Click += new System.EventHandler(this.operationSign);
            // 
            // parseButton
            // 
            this.parseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parseButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.parseButton.Location = new System.Drawing.Point(353, 182);
            this.parseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parseButton.Name = "parseButton";
            this.parseButton.Size = new System.Drawing.Size(70, 58);
            this.parseButton.TabIndex = 0;
            this.parseButton.Text = "button1";
            this.parseButton.UseVisualStyleBackColor = false;
            this.parseButton.Click += new System.EventHandler(this.parseButton_Click);
            // 
            // textDisplay
            // 
            this.textDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.textDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textDisplay.Location = new System.Drawing.Point(15, 20);
            this.textDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.textDisplay.MinimumSize = new System.Drawing.Size(426, 42);
            this.textDisplay.Name = "textDisplay";
            this.textDisplay.ReadOnly = true;
            this.textDisplay.Size = new System.Drawing.Size(582, 45);
            this.textDisplay.TabIndex = 1;
            this.textDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textDisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // unionButton
            // 
            this.unionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unionButton.Location = new System.Drawing.Point(213, 62);
            this.unionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unionButton.Name = "unionButton";
            this.unionButton.Size = new System.Drawing.Size(64, 56);
            this.unionButton.TabIndex = 0;
            this.unionButton.Text = "button1";
            this.unionButton.UseVisualStyleBackColor = true;
            this.unionButton.Click += new System.EventHandler(this.operationSign);
            // 
            // implicationButton
            // 
            this.implicationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.implicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.implicationButton.Location = new System.Drawing.Point(213, 182);
            this.implicationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.implicationButton.Name = "implicationButton";
            this.implicationButton.Size = new System.Drawing.Size(64, 58);
            this.implicationButton.TabIndex = 0;
            this.implicationButton.Text = "button1";
            this.implicationButton.UseVisualStyleBackColor = true;
            this.implicationButton.Click += new System.EventHandler(this.operationSign);
            // 
            // dButton
            // 
            this.dButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dButton.Location = new System.Drawing.Point(73, 62);
            this.dButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dButton.Name = "dButton";
            this.dButton.Size = new System.Drawing.Size(64, 56);
            this.dButton.TabIndex = 0;
            this.dButton.Text = "D";
            this.dButton.UseVisualStyleBackColor = true;
            this.dButton.Click += new System.EventHandler(this.setSign);
            // 
            // cButton
            // 
            this.cButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cButton.Location = new System.Drawing.Point(3, 62);
            this.cButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(64, 56);
            this.cButton.TabIndex = 0;
            this.cButton.Text = "C";
            this.cButton.UseVisualStyleBackColor = true;
            this.cButton.Click += new System.EventHandler(this.setSign);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.aButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.implicationButton, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.parseButton, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.sharpinclusionButton, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.equalityButton, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.bButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.inclusionButton, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.unionButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.emptysetButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.leftparButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.extraSetsButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.rightparButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.gButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.clearButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.sharpneginclusionButton, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.dButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.neginclusionButton, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.backspaceButton, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.differenceButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.complementButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.intersectionButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.fButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.eButton, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 124);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(426, 242);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(15, 70);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.textBox1.MinimumSize = new System.Drawing.Size(426, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(582, 45);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(459, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 64);
            this.textBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(609, 378);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textDisplay);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Sets Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aButton;
        private System.Windows.Forms.Button eButton;
        private System.Windows.Forms.Button gButton;
        private System.Windows.Forms.Button bButton;
        private System.Windows.Forms.Button fButton;
        private System.Windows.Forms.Button extraSetsButton;
        private System.Windows.Forms.Button leftparButton;
        private System.Windows.Forms.Button complementButton;
        private System.Windows.Forms.Button emptysetButton;
        private System.Windows.Forms.Button rightparButton;
        private System.Windows.Forms.Button differenceButton;
        private System.Windows.Forms.Button intersectionButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button neginclusionButton;
        private System.Windows.Forms.Button inclusionButton;
        private System.Windows.Forms.Button equalityButton;
        private System.Windows.Forms.Button backspaceButton;
        private System.Windows.Forms.Button sharpneginclusionButton;
        private System.Windows.Forms.Button sharpinclusionButton;
        private System.Windows.Forms.TextBox textDisplay;
        private System.Windows.Forms.Button parseButton;
        private System.Windows.Forms.Button cButton;
        private System.Windows.Forms.Button dButton;
        private System.Windows.Forms.Button unionButton;
        private System.Windows.Forms.Button implicationButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

