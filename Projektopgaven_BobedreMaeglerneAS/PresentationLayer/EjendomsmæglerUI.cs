﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projektopgaven_BobedreMaeglerneAS.DataAccessLayer;
using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;
using Projektopgaven_BobedreMæglerneAS;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    public partial class EjendomsmæglerUI : Form
    {
        EjendomsmæglerBLL ejendomsmægler;

        public EjendomsmæglerUI()
        {
            InitializeComponent();
        }

        #region Opret Ejendomsmægler
        private void btn_OpretEjendomsmægler_Click(object sender, EventArgs e)
        {
            ejendomsmægler = new EjendomsmæglerBLL(MælgerID(), MæglerCPR(), MæglerTelefon(), MæglerEmail(), MæglerFnavn(), MæglerEnavn(), MæglerVej(), MæglerPostnummer());
            //EjendomsmæglerDAL ejendomsmæglerDAL = new EjendomsmæglerDAL(ejendomsmæglerBLL);

            //Kalder metoden: OpretEjendomsmægler
            //ejendomsmæglerDAL.OpretEjendomsmægler(ejendomsmæglerBLL);

            try
            {
                ejendomsmægler.OpretEjendomsmægler(ejendomsmægler);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Loader data fra databasen ind i datagridview -
            EjendomsmæglerUI_Load(sender, e);
        }
        #endregion

        #region Hent Ejendomsmægler
        private void btn_HentEjendomsmægler_Click(object sender, EventArgs e) 
        {
            ejendomsmægler = new EjendomsmæglerBLL(MælgerID(), MæglerCPR(), MæglerTelefon(), MæglerEmail(), MæglerFnavn(), MæglerEnavn(), MæglerVej(), MæglerPostnummer());
            //EjendomsmæglerDAL ejendomsmæglerDAL = new EjendomsmæglerDAL(ejendomsmæglerBLL);

            try
            {
                EjendomsmæglerBLL matchingejendomsmægler = EjendomsmæglerBLL.HentEjendomsmægler(ejendomsmægler);
                CPR_txt.Text = matchingejendomsmægler.CPR.ToString();
                Telefon_txt.Text = matchingejendomsmægler.Telefon.ToString();
                Email_txt.Text = matchingejendomsmægler.Email.ToString();
                Fornavn_txt.Text = matchingejendomsmægler.Fnavn.ToString();
                Efternavn_txt.Text = matchingejendomsmægler.Enavn.ToString();
                Vej_txt.Text = matchingejendomsmægler.Vej.ToString();
                Postnummer_txt.Text = matchingejendomsmægler.Postnummer.ToString();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Kalder metoden: FindEjendomsmægler
            //ejendomsmæglerDAL.FindEjendomsmægler(ejendomsmæglerBLL);

            //Loader data fra databasen ind i datagridview
            EjendomsmæglerUI_Load(sender, e);
        }
        #endregion

        #region Opdater Ejendomsmægler
        private void btn_OpdaterEjendomsmægler_Click(object sender, EventArgs e)
        {
            ejendomsmægler = new EjendomsmæglerBLL(MælgerID(), MæglerCPR(), MæglerTelefon(), MæglerEmail(), MæglerFnavn(), MæglerEnavn(), MæglerVej(), MæglerPostnummer());
            //EjendomsmæglerDAL ejendomsmæglerDAL = new EjendomsmæglerDAL(ejendomsmæglerBLL);

            //Kalder metoden: OpdaterEjendomsmægler
            //ejendomsmægler.OpdaterEjendomsmægler(ejendomsmægler);

            try
            {
                ejendomsmægler.OpdaterEjendomsmægler(ejendomsmægler);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Loader data fra databasen ind i datagridview
            EjendomsmæglerUI_Load(sender, e);
        }
        #endregion

        #region Slet Ejendomsmægler
        private void btn_SletEjendomsmægler_Click(object sender, EventArgs e)
        {
            ejendomsmægler = new EjendomsmæglerBLL(MælgerID(), MæglerCPR(), MæglerTelefon(), MæglerEmail(), MæglerFnavn(), MæglerEnavn(), MæglerVej(), MæglerPostnummer());
            //EjendomsmæglerDAL ejendomsmæglerDAL = new EjendomsmæglerDAL(ejendomsmæglerBLL);

            //Kalder metoden: SletEjendomsmægler
            //ejendomsmæglerDAL.SletEjendomsmægler(ejendomsmæglerBLL);

            try
            {
                ejendomsmægler.SletEjendomsmægler(ejendomsmægler);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Loader data fra databasen ind i datagridview
            EjendomsmæglerUI_Load(sender, e);
        }
        #endregion

        private void EjendomsmæglerUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ejendomsmægler_bobedredbDataSet.Ejendomsmægler' table. You can move, or remove it, as needed.
            this.ejendomsmæglerTableAdapter.Fill(this.ejendomsmægler_bobedredbDataSet.Ejendomsmægler);

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void MæglerRediger_btn_Click(object sender, EventArgs e)
        {
            EnableAll();
        }

        #region Konveter Tekstbokse
        public int MælgerID()
        {
            int.TryParse(MæglerID_txt.Text, out int mæglerid);
            return mæglerid;
        }

        public int MæglerCPR()
        {
            int.TryParse(CPR_txt.Text, out int mæglercpr);
            return mæglercpr;
        }

        public int MæglerTelefon()
        {
            int.TryParse(Telefon_txt.Text, out int mæglertelefon);
            return mæglertelefon;
        }

        public string MæglerEmail()
        {
            return Email_txt.Text;
        }

        public string MæglerFnavn()
        {
            return Fornavn_txt.Text;
        }

        public string MæglerEnavn()
        {
            return Efternavn_txt.Text;
        }

        public string MæglerVej()
        {
            return Vej_txt.Text;
        }

        public int MæglerPostnummer()
        {
            int.TryParse(Postnummer_txt.Text, out int mæglerpostnummer);
            return mæglerpostnummer;
        }
        #endregion

        #region Tjek tekstboks værdier
        private bool TjekMægleridVærdi()
        {
            if (!int.TryParse(MæglerID_txt.Text, out int i))
            {
                return false;
            }

            return true;
        }

        private bool TjekCPRVærdi()
        {
            if (!int.TryParse(CPR_txt.Text, out int i))
            {
                return false;
            }

            return true;
        }

        private bool TjekTelefonVærdi()
        {
            if(!int.TryParse(Telefon_txt.Text, out int i))
            {
                return false;
            }

            return true;
        }

        public bool TjekEmailVærdi(string input)
        {
            return Regex.IsMatch(input, ("^[a-zA-z æøåÆØÅ-]+@"));
        }

        public bool TjekFnavnVærdi(string input)
        {
            return Regex.IsMatch(input, ("^[a-zA-z æøåÆØÅ-]"));
        }

        public bool TjekEnavnVærdi(string input)
        {
            return Regex.IsMatch(input, ("^[a-zA-z æøåÆØÅ-]"));
        }

        public bool TjekVejVærdi(string input)
        {
            return Regex.IsMatch(input, ("^[a-zA-z æøåÆØÅ-]"));
        }

        public bool TjekPostnummerVærdi()
        {
            if (!int.TryParse(Postnummer_txt.Text, out int i))
            {
                return false;
            }

            return true;
        }
        #endregion
        

        #region MENUBAREN
        //MENUBAREN
        //EJENDOMSMÆGLER MENUBARKNAPPER - I EJENDOMSMÆGLER MENU
        private void createToolStripMenuItem_Click(object sender, EventArgs e) //Opret ejendomsmægler
        {
            MenuBarKnapper.EjendomsmælgerOpret();
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e) //Find/hent ejendomsmægler
        {
            MenuBarKnapper.EjendomsmæglerHentOpdater();
        }

        //private void updateToolStripMenuItem_Click(object sender, EventArgs e) //Opdater ejendomsmægler
        //{
        //    MenuBarKnapper.EjendomsmæglerOpdater();
        //}

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) //Slet ejendomsmægler
        {
            MenuBarKnapper.EjendomsmæglerSlet();
        }

        //SÆLGER MENUBARKNAPPER - I EJENDOMSMÆGLER MENU
        private void createToolStripMenuItem1_Click(object sender, EventArgs e) //Opret sælger
        {
            MenuBarKnapper.SælgerOpret();
        }

        private void readToolStripMenuItem1_Click(object sender, EventArgs e) //Find/hent sælger
        {
            MenuBarKnapper.SælgerHentOpdater();
        }

        //private void updateToolStripMenuItem1_Click(object sender, EventArgs e) //Opdater sælger
        //{
        //    MenuBarKnapper.SælgerOpdater();
        //}

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e) //Slet sælger
        {
            MenuBarKnapper.SælgerSlet();
        }

        //SAG MENUBARKNAPPER - I EJENDOMSMÆGLER MENU
        private void createToolStripMenuItem4_Click(object sender, EventArgs e) //Opret sag
        {
            MenuBarKnapper.SagOpret();
        }

        private void readToolStripMenuItem4_Click(object sender, EventArgs e) //Find/hent sag
        {
            MenuBarKnapper.SagHent();
        }

        private void opdateToolStripMenuItem_Click(object sender, EventArgs e) //Opdater sag
        {
            MenuBarKnapper.SagOpdater();
        }

        private void deleteToolStripMenuItem4_Click(object sender, EventArgs e) //Slet sag
        {
            MenuBarKnapper.SagSlet();
        }

        //KØBER MENUBARKNAPPER - I EJENDOMSMÆGLER MENU
        private void createToolStripMenuItem2_Click(object sender, EventArgs e) //Opret køber
        {
            MenuBarKnapper.KøberCreate();
        }

        private void readToolStripMenuItem2_Click(object sender, EventArgs e) //Find/hent køber
        {
            MenuBarKnapper.KøberRead();
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e) //Opdater køber
        {
            MenuBarKnapper.KøberUpdate();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e) //Slet køber
        {
            MenuBarKnapper.KøberDelete();
        }

        //BOLIG MENUBARKNAPPER - I EJENDOMSMÆGLER MENU
        private void createToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.OpretBolig();
        }

        private void readToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.HentOpdaterBolig();
        }

        private void deleteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.SletBolig();
        }

        //HANDEL MENUBARKNAPPER - I EJENDOMSMÆGLER MENU
        private void createToolStripMenuItem5_Click(object sender, EventArgs e) //Opret handel
        {
            MenuBarKnapper.HandelOpret();
        }

        private void readToolStripMenuItem5_Click(object sender, EventArgs e) //Hent handel
        {
            MenuBarKnapper.HandelHent();
        }

        //private void updateToolStripMenuItem3_Click(object sender, EventArgs e) //Opdater handel
        //{
        //    MenuBarKnapper.HandelOpdater();
        //}

        private void deleteToolStripMenuItem5_Click(object sender, EventArgs e) //Slet handel
        {
            MenuBarKnapper.HandelSlet();
        }

        //ÅBENT HUS MENUBARKNAPPER - I EJENDOMSMÆGLER MENU
        private void komTilÅbentHusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.ÅbentHus();
        }

        #endregion


    }
}
