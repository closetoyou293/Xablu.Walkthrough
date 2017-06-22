﻿using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Plugin.Xablu.Walkthrough.Defaults;
using System.Drawing;
using Walker;
using Splat;

namespace Plugin.Xablu.Walkthrough.Containers
{
    public abstract class BaseContainer : WalkthroughViewPagerBaseFragment
    {
        private ViewPager viewPager;
        public override ViewPager ViewPager
        {
            get => viewPager;
            set => viewPager = value;
        }

        public BaseContainer() { }

        public override void InitializeAdapter(WalkerFragment[] fragments, FragmentManager manager)
        {
            ViewPager.Adapter = new DefaultAdapter(fragments, manager);
            ViewPager.CurrentItem = Page;
        }
    }
}