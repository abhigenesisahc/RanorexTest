﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Genesis.Provider.Legacy.Desktop.RanorexTests
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The GoodsReceipt recording.
    /// </summary>
    [TestModule("48feea21-fdbb-4ee0-b7df-f3175c190670", ModuleType.Recording, 1)]
    public partial class GoodsReceipt : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Genesis_Provider_Legacy_Desktop_RanorexTestsRepository repository.
        /// </summary>
        public static Genesis_Provider_Legacy_Desktop_RanorexTestsRepository repo = Genesis_Provider_Legacy_Desktop_RanorexTestsRepository.Instance;

        static GoodsReceipt instance = new GoodsReceipt();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GoodsReceipt()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static GoodsReceipt Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.SplitControl.OutstandingOrders' at 59;13.", repo.FrmMain.SplitControl.OutstandingOrdersInfo, new RecordItemIndex(0));
            repo.FrmMain.SplitControl.OutstandingOrders.Click("59;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.SplitControl.GoodsReceiptRow0' at 25;16.", repo.FrmMain.SplitControl.GoodsReceiptRow0Info, new RecordItemIndex(1));
            repo.FrmMain.SplitControl.GoodsReceiptRow0.Click("25;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.ReceiptRow0' at 22;13.", repo.PurchaseOrder.ReceiptRow0Info, new RecordItemIndex(2));
            repo.PurchaseOrder.ReceiptRow0.Click("22;13");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
