using System;
using System.Collections.Generic;
using System.Text;

namespace Ciobanu_Serban_Andrei_Lab2
{
   
    public enum DoughnutType
    {
        Glazed,
        Sugar,
        Lemon,
        Chocolate,
        Vanilla
    }
class Doughnut
{
    private DoughnutType mFlavor;

    public DoughnutType Flavor
    {
        get
        {
            return mFlavor;
        }
        set
        {
            mFlavor = value;
        }
    }
    private float mPrice;
    public float Price
    {
        get
        {
            return mPrice;
        }
        set
        {
            mPrice = value;
        }
    }
    public Doughnut(DoughnutType aFlavor) // constructor
    {
        mFlavor = aFlavor;
    }

    }
}