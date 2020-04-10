﻿using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace ExamTwoCodeQuestions.Data
{
    public class Cobbler : IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// Property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// private backing variable for fruit 
        /// </summary>
        private FruitFilling fruit;

        /// <summary>
        /// The fruit used in the cobbler
        /// </summary>
        public FruitFilling Fruit
        {
            get { return fruit; }
            set
            {
                fruit = value;
                NotifyOfPropertyChange("Fruit");
            }
        }

        private bool withIceCream = true;
        /// <summary>
        /// If the cobbler is served with ice cream
        /// </summary>
        public bool WithIceCream
        {
            get { return withIceCream; }
            set
            {
                withIceCream = value;
                NotifyOfPropertyChange("WithIceCream");
            
            }
        }

        /// <summary>
        /// Property to bind a radio button to FruitFilling.Peach
        /// </summary>
        public bool IsPeach
        {
            get { return Fruit == FruitFilling.Peach; }
            set { Fruit = FruitFilling.Peach; }
        }

        /// <summary>
        /// Property to bind a radio button to FruitFilling.Cherry
        /// </summary>
        public bool IsCherry
        {
            get { return Fruit == FruitFilling.Cherry; }
            set { Fruit = FruitFilling.Cherry; }
        }

        /// <summary>
        /// Property to bind a radio button to FruitFilling.Blueberry
        /// </summary>
        public bool IsBlueberry
        {
            get { return Fruit == FruitFilling.Blueberry; }
            set { Fruit = FruitFilling.Blueberry; }
        }

        /// <summary>
        /// Gets the price of the Cobbler
        /// </summary>
        public double Price
        {
            get
            {
                if (WithIceCream) return 5.32;
                else return 4.25;
            }
        }

        /// <summary>
        /// Gets any special instructions for preparing this dessert
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                if(WithIceCream) { return new List<string>(); }
                else { return new List<string>() { "Hold Ice Cream" }; }
            }
        }

        /// <summary>
        /// Notifies order if property changes
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }


    }
}
