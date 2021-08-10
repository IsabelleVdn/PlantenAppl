﻿using PlantenApplicatie.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using GalaSoft.MvvmLight.Ioc;
using Planten2021.Data;
using Planten2021.Domain.Models;
using PlantenApplicatie.Services.Interfaces;
using GalaSoft.MvvmLight.Command;

namespace PlantenApplicatie.Viewmodel
{
    public class ViewModelBloom : ViewModelBase
    {
        // Using a DependencyProperty as the backing store for 
        //IsCheckBoxChecked.  This enables animation, styling, binding, etc...
       
       
        private static SimpleIoc iocc = SimpleIoc.Default;
        private static IDetailService _detailService = iocc.GetInstance<IDetailService>();
        private static ISearchService _SearchService = iocc.GetInstance<ISearchService>();
        private Plant _selectedPlant;
        private List<FenotypeMulti> _fenoTypeMulti;



        public RelayCommand resetBloom { get; set; }

        public bool isChecked;

        public ViewModelBloom(IDetailService detailservice)
        {
            _detailService = detailservice;
            //_selectedPlant = _SearchService.ReturnSelectedPlant();
            resetBloom = new RelayCommand(ResetBloomCommand);
            //fenoTypeMulti = _detailService.FilterFenoMulti(_selectedPlant.PlantId);
        }

        public Plant SelectedPlant
        {
            get
            {
                _selectedPlant = _SearchService.ReturnSelectedPlant();
                return _selectedPlant;
            }


            set
            {
                _selectedPlant = value;

                OnPropertyChanged();
            }
        }

        public List<FenotypeMulti> fenoTypeMulti 
        {
            get
            {
                _fenoTypeMulti = _detailService.FilterFenoMulti(_selectedPlant.PlantId);
                return _fenoTypeMulti;
            }

            set
            {
                _fenoTypeMulti = value;

                OnPropertyChanged();
            }
        }

        public void doesItNeedToBeChecked()
        {
            //isChecked = true;

            foreach (var fenotypeMulti in fenoTypeMulti)
            {
                if (fenotypeMulti.Waarde == "zwart" && fenotypeMulti.Maand == "jan")
                {
                    isChecked = true;
                }

                else
                {
                    isChecked = false;
                }
            }

        }
        private void ResetBloomCommand()
        {
            //_selectedPlant = _SearchService.ReturnSelectedPlant();

            //fenoTypeMulti = _detailService.FilterFenoMulti(_selectedPlant.PlantId);

            //if (_selectedPlant == null)
            //{
            //    MessageBox.Show("Je hebt nog geen plant geselecteerd!");
            //}

            //else
            //{
            //    _detailService.FilterFenoMulti(_selectedPlant.PlantId);
            //    //MessageBox.Show(_selectedPlant.Familie + " tadaah");
            //}

            fenoTypeMulti = _detailService.FilterFenoMulti(_selectedPlant.PlantId);
            if (_selectedPlant == null)
            {
                MessageBox.Show("Je hebt nog geen plant geselecteerd!");
            }
            else
            {

                //_detailService.FilterFenoMulti(_selectedPlant.PlantId);
                //MessageBox.Show(_selectedPlant.Familie + " tadaah");
                //DoesItNeedToBeChecked();
            }
        }


        #region Checkbox Bloeikleur

        
        private bool _selectedCheckBoxBloeikleurZwart;
        public bool SelectedCheckBoxBloeikleurZwart
        {
            get
            {
                _selectedPlant = _SearchService.ReturnSelectedPlant();

                if (_selectedPlant.Familie == "BRASSICACEAE")
                {
                    isChecked = true;
                }

                else
                {
                    isChecked = false;
                }

                _selectedCheckBoxBloeikleurZwart = isChecked;

                return _selectedCheckBoxBloeikleurZwart;
            }

            set
            {
                _selectedCheckBoxBloeikleurZwart = value;
                OnPropertyChanged();
            }
        }



        private bool _selectedCheckBoxBloeikleurWit;
        public bool SelectedCheckBoxBloeikleurWit
        {
            get { return _selectedCheckBoxBloeikleurWit; }

            set
            {
                _selectedCheckBoxBloeikleurWit = isChecked;

                

                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeikleurRosé;
        public bool SelectedCheckBoxBloeikleurRosé
        {
            get { return _selectedCheckBoxBloeikleurRosé; }

            set
            {
                _selectedCheckBoxBloeikleurRosé = isChecked;
               OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeikleurRood;
        public bool SelectedCheckBoxBloeikleurRood
        {
            get { return _selectedCheckBoxBloeikleurRood; }

            set
            {
                _selectedCheckBoxBloeikleurRood = isChecked;
               OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeikleurOranje;
        public bool SelectedCheckBoxBloeikleurOranje
        {
            get { return _selectedCheckBoxBloeikleurOranje; }

            set
            {
                _selectedCheckBoxBloeikleurOranje = isChecked;
               OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeikleurLila;
        public bool SelectedCheckBoxBloeikleurLila
        {
            get { return _selectedCheckBoxBloeikleurLila; }

            set
            {
                _selectedCheckBoxBloeikleurLila = isChecked;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeikleurGrijs;
        public bool SelectedCheckBoxBloeikleurGrijs
        {
            get { return _selectedCheckBoxBloeikleurGrijs; }

            set
            {
                _selectedCheckBoxBloeikleurGrijs = isChecked;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeikleurGroen;
        public bool SelectedCheckBoxBloeikleurGroen
        {
            get { return _selectedCheckBoxBloeikleurGroen; }

            set
            {
                _selectedCheckBoxBloeikleurGroen = isChecked;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeikleurGeel;
        public bool SelectedCheckBoxBloeikleurGeel
        {
            get { return _selectedCheckBoxBloeikleurGeel; }

            set
            {
                _selectedCheckBoxBloeikleurGeel= isChecked;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeikleurBlauw;
        public bool SelectedCheckBoxBloeikleurBlauw
        {
            get {
                _selectedPlant = _SearchService.ReturnSelectedPlant();

                if (_selectedPlant.Familie == "BRASSICACEAE")
                {
                    isChecked = true;
                }

                else
                {
                    isChecked = false;
                }

                _selectedCheckBoxBloeikleurBlauw = isChecked;

                return _selectedCheckBoxBloeikleurBlauw;
                }

            set
            {
                _selectedCheckBoxBloeikleurBlauw = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeikleurViolet;
        public bool SelectedCheckBoxBloeikleurViolet
        {
            get { return _selectedCheckBoxBloeikleurViolet; }

            set
            {
                _selectedCheckBoxBloeikleurViolet = isChecked;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeikleurPaars;
        public bool SelectedCheckBoxBloeikleurPaars
        {
            get { return _selectedCheckBoxBloeikleurPaars; }

            set
            {
                _selectedCheckBoxBloeikleurPaars = isChecked;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeikleurBruin;
        public bool SelectedCheckBoxBloeikleurBruin
        {
            get { return _selectedCheckBoxBloeikleurBruin; }

            set
            {
                _selectedCheckBoxBloeikleurBruin = isChecked;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeikleurJan;
        public bool SelectedCheckBoxBloeikleurJan
        {
            get {
                
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Waarde == "zwart")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }

                _selectedCheckBoxBloeikleurJan = isChecked;

                return _selectedCheckBoxBloeikleurJan;

            }

            set
            {
                _selectedCheckBoxBloeikleurJan = isChecked;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeikleurFeb;
        public bool SelectedCheckBoxBloeikleurFeb
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Waarde == "zwart")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }

                _selectedCheckBoxBloeikleurFeb = isChecked;

                return _selectedCheckBoxBloeikleurFeb;
            }

            set
            {
                _selectedCheckBoxBloeikleurFeb = isChecked;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeikleurMar;
        public bool SelectedCheckBoxBloeikleurMar
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Waarde == "zwart")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }

                _selectedCheckBoxBloeikleurMar = isChecked;

                return _selectedCheckBoxBloeikleurMar;
            }

            set
            {
                _selectedCheckBoxBloeikleurMar = isChecked;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeikleurApr;
        public bool SelectedCheckBoxBloeikleurApr
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Waarde == "zwart")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }

                _selectedCheckBoxBloeikleurApr = isChecked;

                return _selectedCheckBoxBloeikleurApr;
            }

            set
            {
                _selectedCheckBoxBloeikleurApr = isChecked;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeikleurMay;
        public bool SelectedCheckBoxBloeikleurMay
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Waarde == "zwart")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }

                _selectedCheckBoxBloeikleurMay = isChecked;

                return _selectedCheckBoxBloeikleurMay;
            }

            set
            {
                _selectedCheckBoxBloeikleurMay = isChecked;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeikleurJun;
        public bool SelectedCheckBoxBloeikleurJun
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Waarde == "zwart")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }

                _selectedCheckBoxBloeikleurJun = isChecked;

                return _selectedCheckBoxBloeikleurJun;
            }

            set
            {
                _selectedCheckBoxBloeikleurJun = isChecked;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeikleurJul;
        public bool SelectedCheckBoxBloeikleurJul
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Waarde == "zwart")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }

                _selectedCheckBoxBloeikleurJul = isChecked;

                return _selectedCheckBoxBloeikleurJul;
            }

            set
            {
                _selectedCheckBoxBloeikleurJul = isChecked;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeikleurAug;
        public bool SelectedCheckBoxBloeikleurAug
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Waarde == "zwart")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }

                _selectedCheckBoxBloeikleurAug = isChecked;

                return _selectedCheckBoxBloeikleurAug;
            }

            set
            {
                _selectedCheckBoxBloeikleurAug = isChecked;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeikleurSep;
        public bool SelectedCheckBoxBloeikleurSep
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Waarde == "zwart")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }

                _selectedCheckBoxBloeikleurSep = isChecked;

                return _selectedCheckBoxBloeikleurSep;
            }

            set
            {
                _selectedCheckBoxBloeikleurSep = isChecked;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeikleurOct;
        public bool SelectedCheckBoxBloeikleurOct
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Waarde == "zwart")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }

                _selectedCheckBoxBloeikleurOct = isChecked;

                return _selectedCheckBoxBloeikleurOct;
            }

            set
            {
                _selectedCheckBoxBloeikleurOct = isChecked;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeikleurNov;
        public bool SelectedCheckBoxBloeikleurNov
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Waarde == "zwart")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }

                _selectedCheckBoxBloeikleurNov = isChecked;

                return _selectedCheckBoxBloeikleurNov;
            }

            set
            {
                _selectedCheckBoxBloeikleurNov = isChecked;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeikleurDec;
        public bool SelectedCheckBoxBloeikleurDec
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Waarde == "zwart")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }

                _selectedCheckBoxBloeikleurDec = isChecked;

                return _selectedCheckBoxBloeikleurDec;
            }

            set
            {
                _selectedCheckBoxBloeikleurDec = isChecked;
                OnPropertyChanged();
            }
        }

        #endregion
        private string _selectedBloeiHoogte;

        public string SelectedBloeiHoogte
        {
            get
            {
                return _selectedBloeiHoogte;
            }
            set
            {
                _selectedBloeiHoogte = value;
                OnPropertyChanged();


            }
        }
        #region Binding Combobox BloeiHoogte

        private bool _selectedCboBloeiHoogteMinJan;
        public bool SelectedCboBloeiHoogteMinJan
        {
            get
            {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeiHoogteMinJan")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }

                _selectedCboBloeiHoogteMinJan = isChecked;

                return _selectedCboBloeiHoogteMinJan;
            }

            set
            {
                _selectedCboBloeiHoogteMinJan = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCboBloeiHoogteMaxJan;
        public bool SelectedCboBloeiHoogteMaxJan
        {
            get
            {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeiHoogteMaxJan")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                _selectedCboBloeiHoogteMaxJan = isChecked;
                return _selectedCboBloeiHoogteMaxJan;
            }

            set
            {
                _selectedCboBloeiHoogteMaxJan = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCboBloeiHoogteMinFeb;
        public bool SelectedCboBloeiHoogteMinFeb
        {
            get
            {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeiHoogteMinFeb")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }

                _selectedCboBloeiHoogteMinFeb = isChecked;
                return _selectedCboBloeiHoogteMinFeb;
            }

            set
            {
                _selectedCboBloeiHoogteMinFeb = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCboBloeiHoogteMaxFeb;
        public bool SelectedCboBloeiHoogteMaxFeb
        {
            get
            {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeiHoogteMaxFeb")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                _selectedCboBloeiHoogteMaxFeb = isChecked;
                return _selectedCboBloeiHoogteMaxFeb;
            }

            set
            {
                _selectedCboBloeiHoogteMaxFeb = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCboBloeiHoogteMinMar;
        public bool SelectedCboBloeiHoogteMinMar
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeiHoogteMinMar")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                _selectedCboBloeiHoogteMinMar = isChecked;
                return _selectedCboBloeiHoogteMinMar;
            }

            set
            {
                _selectedCboBloeiHoogteMinMar = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCboBloeiHoogteMaxMar;
        public bool SelectedCboBloeiHoogteMaxMar
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeiHoogteMaxMar")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                _selectedCboBloeiHoogteMaxMar = isChecked;
                return _selectedCboBloeiHoogteMaxMar;
            }

            set
            {
                _selectedCboBloeiHoogteMaxMar = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCboBloeiHoogteMinApr;
        public bool SelectedCboBloeiHoogteMinApr
        {
            get
            {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeiHoogteMinApr")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                _selectedCboBloeiHoogteMinApr = isChecked;
                return _selectedCboBloeiHoogteMinApr;
            }

            set
            {
                _selectedCboBloeiHoogteMinApr = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCboBloeiHoogteMaxApr;
        public bool SelectedCboBloeiHoogteMaxApr
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeiHoogteMaxApr")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                _selectedCboBloeiHoogteMaxApr = isChecked;
                return _selectedCboBloeiHoogteMaxApr;
            }

            set
            {
                _selectedCboBloeiHoogteMaxApr = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCboBloeiHoogteMinMay;
        public bool SelectedCboBloeiHoogteMinMay
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeiHoogteMinMay")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                _selectedCboBloeiHoogteMinMay = isChecked;
                return _selectedCboBloeiHoogteMinMay;
            }

            set
            {
                _selectedCboBloeiHoogteMinMay = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCboBloeiHoogteMaxMay;
        public bool SelectedCboBloeiHoogteMaxMay
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeiHoogteMaxMay")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                _selectedCboBloeiHoogteMaxMay = isChecked;
                return _selectedCboBloeiHoogteMaxMay;
            }

            set
            {
                _selectedCboBloeiHoogteMaxMay = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCboBloeiHoogteMinJun;
        public bool SelectedCboBloeiHoogteMinJun
        {
            get
            {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeiHoogteMinJun")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                _selectedCboBloeiHoogteMinJun = isChecked;
                return _selectedCboBloeiHoogteMinJun;
            }

            set
            {
                _selectedCboBloeiHoogteMinJun = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCboBloeiHoogteMaxJun;
        public bool SelectedCboBloeiHoogteMaxJun
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeiHoogteMaxJun")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                _selectedCboBloeiHoogteMaxJul = isChecked;
                return _selectedCboBloeiHoogteMaxJun;
            }

            set
            {
                _selectedCboBloeiHoogteMaxJun = value;
                OnPropertyChanged();
            }
        }
        private bool _selectedCboBloeiHoogteMinJul;
        public bool SelectedCboBloeiHoogteMinJul
        {
            get
            {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeiHoogteMinJul")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                _selectedCboBloeiHoogteMinJul = isChecked;
                return _selectedCboBloeiHoogteMinJul;
            }

            set
            {
                _selectedCboBloeiHoogteMinJul = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCboBloeiHoogteMaxJul;
        public bool SelectedCboBloeiHoogteMaxJul
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeiHoogteMaxJul")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                _selectedCboBloeiHoogteMaxJul = isChecked;
                return _selectedCboBloeiHoogteMaxJul;
            }

            set
            {
                _selectedCboBloeiHoogteMaxJul = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCboBloeiHoogteMinAug;
        public bool SelectedCboBloeiHoogteMinAug
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeiHoogteMinAug")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                _selectedCboBloeiHoogteMinAug = isChecked;
                return _selectedCboBloeiHoogteMinAug;
            }

            set
            {
                _selectedCboBloeiHoogteMinAug = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCboBloeiHoogteMaxAug;
        public bool SelectedCboBloeiHoogteMaxAug
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeiHoogteMaxAug")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                _selectedCboBloeiHoogteMaxAug = isChecked;
                return _selectedCboBloeiHoogteMaxAug;
            }

            set
            {
                _selectedCboBloeiHoogteMaxAug = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCboBloeiHoogteMinSep;
        public bool SelectedCboBloeiHoogteMinSep
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeiHoogteMinSep")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                _selectedCboBloeiHoogteMinSep = isChecked;
                return _selectedCboBloeiHoogteMinSep;
            }

            set
            {
                _selectedCboBloeiHoogteMinSep = value;
                OnPropertyChanged();
            }
        }
        private bool _selectedCboBloeiHoogteMaxSep;
        public bool SelectedCboBloeiHoogteMaxSep
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeiHoogteMaxSep")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                _selectedCboBloeiHoogteMaxSep = isChecked;
                return _selectedCboBloeiHoogteMaxSep;
            }

            set
            {
                _selectedCboBloeiHoogteMaxSep = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCboBloeiHoogteMinOct;
        public bool SelectedCboBloeiHoogteMinOct
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeiHoogteMinOct")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                _selectedCboBloeiHoogteMinOct = isChecked;
                return _selectedCboBloeiHoogteMinOct;
            }

            set
            {
                _selectedCboBloeiHoogteMinOct = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCboBloeiHoogteMaxOct;
        public bool SelectedCboBloeiHoogteMaxOct
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeiHoogteMaxOct")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                _selectedCboBloeiHoogteMaxOct= isChecked;
                return _selectedCboBloeiHoogteMaxOct;
            }

            set
            {
                _selectedCboBloeiHoogteMaxOct = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCboBloeiHoogteMinNov;
        public bool SelectedCboBloeiHoogteNov
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeiHoogteMinNov")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                _selectedCboBloeiHoogteMinNov = isChecked;
                return _selectedCboBloeiHoogteMinNov;
            }

            set
            {
                _selectedCboBloeiHoogteMinNov = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCboBloeiHoogteMaxNov;
        public bool SelectedCboBloeiHoogteMaxNov
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeiHoogteMaxNov")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                _selectedCboBloeiHoogteMaxNov = isChecked;
                return _selectedCboBloeiHoogteMaxNov;
            }

            set
            {
                _selectedCboBloeiHoogteMaxNov = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCboBloeiHoogteMinDec;
        public bool SelectedCboBloeiHoogteDec
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeiHoogteMinDec")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                _selectedCboBloeiHoogteMinDec = isChecked;
                return _selectedCboBloeiHoogteMinDec;
            }

            set
            {
                _selectedCboBloeiHoogteMinDec = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCboBloeiHoogteMaxDec;
        public bool SelectedCboBloeiHoogteMaxDec
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeiHoogteMaxDec")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                _selectedCboBloeiHoogteMaxDec = isChecked;
                return _selectedCboBloeiHoogteMaxDec;
            }

            set
            {
                _selectedCboBloeiHoogteMaxDec = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Binding Checkbox Bloeit In

        private bool _selectedCheckBoxBloeitInJan;
        
        public bool SelectedCheckBoxBloeitInJan
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeitInJan")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                return _selectedCheckBoxBloeitInJan;
            }

            set
            {
                _selectedCheckBoxBloeitInJan = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeitInFeb;
        public bool SelectedCheckBoxBloeitInFeb
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeitInFeb")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                return _selectedCheckBoxBloeitInFeb;
            }

            set
            {
                _selectedCheckBoxBloeitInFeb = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeitInMar;
        public bool SelectedCheckBoxBloeitInMar
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeitInMar")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                return _selectedCheckBoxBloeitInMar;
            }

            set
            {
                _selectedCheckBoxBloeitInMar = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeitInApr;
        public bool SelectedCheckBoxBloeitInApr
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeitInApr")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                return _selectedCheckBoxBloeitInApr;
            }

            set
            {
                _selectedCheckBoxBloeitInApr = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeitInMay;
        public bool SelectedCheckBoxBloeitInMay
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeitInMay")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                return _selectedCheckBoxBloeitInMay;
            }

            set
            {
                _selectedCheckBoxBloeitInMay = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeitInJun;
        public bool SelectedCheckBoxBloeitInJun
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeitInJun")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                return _selectedCheckBoxBloeitInJun;
            }

            set
            {
                _selectedCheckBoxBloeitInJun = value;
                OnPropertyChanged();
            }
        }
        private bool _selectedCheckBoxBloeitInJul;
        public bool SelectedCheckBoxBloeitInJul
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeitInJul")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                return _selectedCheckBoxBloeitInJul;
            }

            set
            {
                _selectedCheckBoxBloeitInJul = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeitInAug;
        public bool SelectedCheckBoxBloeitInAug
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeitInAug")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                return _selectedCheckBoxBloeitInAug;
            }

            set
            {
                _selectedCheckBoxBloeitInAug = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeitInSep;
        public bool SelectedCheckBoxBloeitInSep
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeitInSep")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                return _selectedCheckBoxBloeitInSep;
            }

            set
            {
                _selectedCheckBoxBloeitInSep = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeitInOct;
        public bool SelectedCheckBoxBloeitInOct
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeitInOct")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                return _selectedCheckBoxBloeitInOct;
            }

            set
            {
                _selectedCheckBoxBloeitInOct = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeitInNov;
        public bool SelectedCheckBoxBloeitInNov
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeitInNov")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                return _selectedCheckBoxBloeitInNov;
            }

            set
            {
                _selectedCheckBoxBloeitInNov = value;
                OnPropertyChanged();
            }
        }

        private bool _selectedCheckBoxBloeitInDec;
        public bool SelectedCheckBoxBloeitInDec
        {
            get {
                foreach (var fenotypeMulti in fenoTypeMulti)
                {
                    if (fenotypeMulti.Eigenschap == "BloeitInDec")
                    {
                        isChecked = true;
                    }

                    else
                    {
                        isChecked = false;
                    }
                }
                return _selectedCheckBoxBloeitInDec;
            }

            set
            {
                _selectedCheckBoxBloeitInDec = value;
                OnPropertyChanged();
            }
        }


        #endregion

        #region Binding Combobox Bloeiwijze

        //public void fillComboBoxBloeiwijze()
        //{
        //    var list = _dao.fillComboboxBloeiwijze();

        //    foreach (var item in list)
        //    {

        //        CboBloeiwijze.Add(item);

        //    }
        //}

        private string _selectedCboBloeiwijze;

        public string SelectedCboBloeiwijze
        {
            get { return _selectedCboBloeiwijze; }
            set
            {
                _selectedCboBloeiwijze = value;
                OnPropertyChanged();

            }
        }
        #endregion

        //    #region Binding checkboxes Bloeiwijzevorm

        //    private bool _selectedCheckBoxBloeiwijzeVorm1;
        //    public bool SelectedCheckBoxBloeiwijzeVorm1
        //    {
        //        get { return _selectedCheckBoxBloeiwijzeVorm1; }

        //        set
        //        {
        //            _selectedCheckBoxBloeiwijzeVorm1 = value;
        //            OnPropertyChanged();
        //        }
        //    }

        //    private bool _selectedCheckBoxBloeiwijzeVorm2;
        //    public bool SelectedCheckBoxBloeiwijzeVorm2
        //    {
        //        get { return _selectedCheckBoxBloeiwijzeVorm2; }

        //        set
        //        {
        //            _selectedCheckBoxBloeiwijzeVorm2 = value;
        //            OnPropertyChanged();
        //        }
        //    }

        //    private bool _selectedCheckBoxBloeiwijzeVorm3;
        //    public bool SelectedCheckBoxBloeiwijzeVorm3
        //    {
        //        get { return _selectedCheckBoxBloeiwijzeVorm3; }

        //        set
        //        {
        //            _selectedCheckBoxBloeiwijzeVorm3 = value;
        //            OnPropertyChanged();
        //        }
        //    }

        //    private bool _selectedCheckBoxBloeiwijzeVorm4;
        //    public bool SelectedCheckBoxBloeiwijzeVorm4
        //    {
        //        get { return _selectedCheckBoxBloeiwijzeVorm4; }

        //        set
        //        {
        //            _selectedCheckBoxBloeiwijzeVorm4 = value;
        //            OnPropertyChanged();
        //        }
        //    }

        //    private bool _selectedCheckBoxBloeiwijzeVorm5;
        //    public bool SelectedCheckBoxBloeiwijzeVorm5
        //    {
        //        get { return _selectedCheckBoxBloeiwijzeVorm5; }

        //        set
        //        {
        //            _selectedCheckBoxBloeiwijzeVorm5 = value;
        //            OnPropertyChanged();
        //        }
        //    }

        //    private bool _selectedCheckBoxBloeiwijzeVorm6;
        //    public bool SelectedCheckBoxBloeiwijzeVorm6
        //    {
        //        get { return _selectedCheckBoxBloeiwijzeVorm6; }

        //        set
        //        {
        //            _selectedCheckBoxBloeiwijzeVorm6 = value;
        //            OnPropertyChanged();
        //        }
        //    }

        //    #endregion
    }
}

