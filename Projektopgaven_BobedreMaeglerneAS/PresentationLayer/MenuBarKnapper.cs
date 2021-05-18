﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projektopgaven_BobedreMæglerneAS;

namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    class MenuBarKnapper
    {
        public static void KøberCreate()
        {
            //if (Application.OpenForms.OfType<KøberUI>().Count() == 0)
            //{
            //    KøberUI køberUI = new KøberUI();
            //    køberUI.Show();
            //}
            KøberUI køberUI = new KøberUI();
            køberUI.Show();
            køberUI.KøberID_txt.Enabled = true;
            køberUI.KøberCPR_txt.Enabled = true;
            køberUI.KøberFornavn_txt.Enabled = true;
            køberUI.KøberEfternavn_txt.Enabled = true;
            køberUI.KøberEmail_txt.Enabled = true;
            køberUI.KøberTelefon_txt.Enabled = true;
            køberUI.KøberVej_txt.Enabled = true;
            køberUI.KøberPostnummer_txt.Enabled = true;
            //køberUI.OpretKøber_knap.Visible = true;
            //køberUI.SletKøber_knap.Visible = false;
            //køberUI.OpdaterKøber_knap.Visible = false;
            //køberUI.FindKøber_knap.Visible = false;
        }
        public static void KøberRead()
        {
            KøberUI køberUI = new KøberUI();
            køberUI.Show();
            køberUI.KøberID_txt.Enabled = true;
            køberUI.KøberCPR_txt.Enabled = true;
            køberUI.KøberFornavn_txt.Enabled = true;
            køberUI.KøberEfternavn_txt.Enabled = true;
            køberUI.KøberEmail_txt.Enabled = true;
            køberUI.KøberTelefon_txt.Enabled = true;
            køberUI.KøberVej_txt.Enabled = true;
            køberUI.KøberPostnummer_txt.Enabled = true;
            //køberUI.OpretKøber_knap.Visible = false;
            //køberUI.SletKøber_knap.Visible = false;
            //køberUI.OpdaterKøber_knap.Visible = false;
            //køberUI.FindKøber_knap.Visible = true;
        }
        public static void KøberDelete()
        {
            KøberUI køberUI = new KøberUI();
            køberUI.Show();
            køberUI.KøberID_txt.Enabled = true;
            køberUI.KøberCPR_txt.Enabled = true;
            køberUI.KøberFornavn_txt.Enabled = true;
            køberUI.KøberEfternavn_txt.Enabled = true;
            køberUI.KøberEmail_txt.Enabled = true;
            køberUI.KøberTelefon_txt.Enabled = true;
            køberUI.KøberVej_txt.Enabled = true;
            køberUI.KøberPostnummer_txt.Enabled = true;
            //køberUI.OpretKøber_knap.Visible = false;
            //køberUI.SletKøber_knap.Visible = true;
            //køberUI.OpdaterKøber_knap.Visible = false;
            //køberUI.FindKøber_knap.Visible = false;
        }
        public static void KøberUpdate()
        {
            KøberUI køberUI = new KøberUI();
            køberUI.Show();
            køberUI.KøberID_txt.Enabled = true;
            køberUI.KøberCPR_txt.Enabled = true;
            køberUI.KøberFornavn_txt.Enabled = true;
            køberUI.KøberEfternavn_txt.Enabled = true;
            køberUI.KøberEmail_txt.Enabled = true;
            køberUI.KøberTelefon_txt.Enabled = true;
            køberUI.KøberVej_txt.Enabled = true;
            køberUI.KøberPostnummer_txt.Enabled = true;
            //køberUI.OpretKøber_knap.Visible = false;
            //køberUI.SletKøber_knap.Visible = false;
            //køberUI.OpdaterKøber_knap.Visible = true;
            //køberUI.FindKøber_knap.Visible = false;
        }

        public static void EjendomsmælgerOpret()
        {
            // Opretter en ny instans af EjendomsmæglerUI klassen
            EjendomsmæglerUI ejendomsmæglerUI = new EjendomsmæglerUI();

            // Show the settings form
            ejendomsmæglerUI.Show();

            ejendomsmæglerUI.GetHentEjendomsmæglerKnap().Visible = false;
            ejendomsmæglerUI.GetOpdaterEjendomsmæglerKnap().Visible = false;
            ejendomsmæglerUI.GetSletEjendomsmæglerKnap().Visible = false;
            ejendomsmæglerUI.GetMæglerIDTekstboks().Enabled = false;
        }

        public static void EjendomsmæglerHent()
        {
            // Opretter en ny instans af EjendomsmæglerUI klassen
            EjendomsmæglerUI ejendomsmæglerUI = new EjendomsmæglerUI();

            // Show the settings form
            ejendomsmæglerUI.Show();

            ejendomsmæglerUI.GetOpretEjendomsmæglerKnap().Visible = false;
            ejendomsmæglerUI.GetOpdaterEjendomsmæglerKnap().Visible = false;
            ejendomsmæglerUI.GetSletEjendomsmæglerKnap().Visible = false;
        }

        public static void EjendomsmæglerOpdater()
        {
            // Opretter en ny instans af EjendomsmæglerUI klassen
            EjendomsmæglerUI ejendomsmæglerUI = new EjendomsmæglerUI();

            // Show the settings form
            ejendomsmæglerUI.Show();

            ejendomsmæglerUI.GetOpretEjendomsmæglerKnap().Visible = false;
            ejendomsmæglerUI.GetHentEjendomsmæglerKnap().Visible = false;
            ejendomsmæglerUI.GetSletEjendomsmæglerKnap().Visible = false;
        }

        public static void EjendomsmæglerSlet()
        {
            // Opretter en ny instans af EjendomsmæglerUI klassen
            EjendomsmæglerUI ejendomsmæglerUI = new EjendomsmæglerUI();

            // Show the settings form
            ejendomsmæglerUI.Show();

            //Skjuler knapper og deaktivere tekstbokse
            ejendomsmæglerUI.GetOpretEjendomsmæglerKnap().Visible = false;
            ejendomsmæglerUI.GetHentEjendomsmæglerKnap().Visible = false;
            ejendomsmæglerUI.GetOpdaterEjendomsmæglerKnap().Visible = false;
            ejendomsmæglerUI.GetCPRTekstboks().Enabled = false;
            ejendomsmæglerUI.GetTelefonTekstboks().Enabled = false;
            ejendomsmæglerUI.GetEmailTekstboks().Enabled = false;
            ejendomsmæglerUI.GetFnavnTekstboks().Enabled = false;
            ejendomsmæglerUI.GetEnavnTekstboks().Enabled = false;
            ejendomsmæglerUI.GetVejTekstboks().Enabled = false;
            ejendomsmæglerUI.GetPostnummerTekstboks().Enabled = false;
        }

        public static void OpretBolig() 
        {
            // Create a new instance of the BoligUI class
            BoligUI boligUI = new BoligUI();

            // Show the settings form
            boligUI.Show();

            // Disable not needed buttons
            boligUI.GetHentBoligButton().Visible = false;
            boligUI.GetSletBoligButton().Visible = false;
            boligUI.GetClearHentBoligButton().Visible = false;
            boligUI.GetAllowRedigeringButton().Visible = false;
            boligUI.GetSaveChangesButton().Visible = false;

            // Disable not needed textboxes
            boligUI.GetBoligIDTextbox().Enabled = false;
            boligUI.GetBoligRenoveringsÅrDateTimePicker().Enabled = false;
            boligUI.GetBoligUdbudsprisTextbox().Enabled = false;
        }

        public static void HentOpdaterBolig()
        {            
            // Create a new instance of the BoligUI class
            BoligUI boligUI = new BoligUI();

            // Show the settings form
            boligUI.Show();

            // Disable not needed buttons
            boligUI.GetOpretBoligButton().Visible = false;
            boligUI.GetSletBoligButton().Visible = false;
            boligUI.GetClearOpretBoligButton().Visible = false;

            boligUI.DisableAll();
            boligUI.GetBoligIDTextbox().Enabled = true;
        }

        public static void HentOpdaterBolig(string boligid)
        {
            // Create a new instance of the BoligUI class
            BoligUI boligUI = new BoligUI();

            // Show the settings form
            boligUI.Show();

            // Disable not needed buttons
            boligUI.GetOpretBoligButton().Visible = false;
            boligUI.GetSletBoligButton().Visible = false;
            boligUI.GetClearOpretBoligButton().Visible = false;

            boligUI.DisableAll();
            boligUI.GetBoligIDTextbox().Enabled = true;

            boligUI.GetBoligIDTextbox().Text = boligid;
            boligUI.HentClick();
        }

        public static void SletBolig()
        {            
            // Create a new instance of the BoligUI class
            BoligUI boligUI = new BoligUI();

            // Show the settings form
            boligUI.Show();

            // Disable not needed buttons
            boligUI.GetOpretBoligButton().Visible = false;
            boligUI.GetHentBoligButton().Visible = false;
            boligUI.GetClearOpretBoligButton().Visible = false;
            boligUI.GetClearHentBoligButton().Visible = false;
            boligUI.GetAllowRedigeringButton().Visible = false;
            boligUI.GetSaveChangesButton().Visible = false;

            // Disable not needed TextBoxes
            boligUI.DisableAll();
            boligUI.GetBoligIDTextbox().Enabled = true;
        }
    }
}
