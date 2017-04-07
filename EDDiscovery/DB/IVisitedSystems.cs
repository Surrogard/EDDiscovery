﻿/*
 * Copyright © 2015 - 2016 EDDiscovery development team
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this
 * file except in compliance with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software distributed under
 * the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF
 * ANY KIND, either express or implied. See the License for the specific language
 * governing permissions and limitations under the License.
 * 
 * EDDiscovery is not affiliated with Frontier Developments plc.
 */
using System;

namespace EDDiscovery.DB
{
    public interface IVisitedSystems
    {
        long id { get; set; }
        string Name { get; set; }
        DateTime Time { get; set; }
        int Commander { get; set; }
        long Source { get; set; }
        string Unit { get; set; }
        bool EDSM_sync { get; set; }
        int MapColour { get; set; }
        double X { get; set; }
        double Y { get; set; }
        double Z { get; set; }


        bool Update();
    }
}