﻿using Learning.CSharp.Nove.Common;

namespace Learning.CSharp.Nove.TargetTypedNew
{
    public class LearningTargetTypedNewSample
    {
        public string Name { get; init; }
        public string ReadOnlyProperty { get; init; }
    }

    public class LearningTargetTypedNew
    {
        public static void Start()
        {
            var oldWay = new LearningTargetTypedNewSample
            {
                Name = "oldWay",
                ReadOnlyProperty = "oldWay"
            };

            LearningTargetTypedNewSample newWay = new() { ReadOnlyProperty = "new Way", Name = "new Way" };

            PrinterHelper.Print(oldWay);
            PrinterHelper.Print(newWay);
        }
    }
}
