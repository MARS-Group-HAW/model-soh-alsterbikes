using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mars.Interfaces.Environments;

namespace SOHMultimodalModel.Model
{
    public class BicycleLeaderRoute
    {
        public static Queue<Position> GetRoute()
        {
            Queue<Position> stops = new Queue<Position>();

            stops.Enqueue(new Position(9.992039, 53.553669));
            stops.Enqueue(new Position(9.987881, 53.555613));
            stops.Enqueue(new Position(9.990386, 53.559870));
            stops.Enqueue(new Position(9.994812, 53.565207));
            stops.Enqueue(new Position(10.002708, 53.587041));
            stops.Enqueue(new Position(10.016785, 53.565280));
            stops.Enqueue(new Position(10.000632, 53.555887));
            stops.Enqueue(new Position(9.992103, 53.553624));

            return stops;
        }

        public static Queue<Position> GetOldRoute()
        {
            Queue<Position> stops = new Queue<Position>();

            stops.Enqueue(new Position(9.99175, 53.55397));
            stops.Enqueue(new Position(9.99121, 53.55428));
            stops.Enqueue(new Position(9.9911, 53.55433));
            stops.Enqueue(new Position(9.99106, 53.55435));
            stops.Enqueue(new Position(9.99094, 53.55439));
            stops.Enqueue(new Position(9.99085, 53.55441));
            stops.Enqueue(new Position(9.99085, 53.55441));
            stops.Enqueue(new Position(9.9908, 53.55441));
            stops.Enqueue(new Position(9.9908, 53.55441));
            stops.Enqueue(new Position(9.99078, 53.55446));
            stops.Enqueue(new Position(9.99077, 53.55448));
            stops.Enqueue(new Position(9.99077, 53.55448));
            stops.Enqueue(new Position(9.99071, 53.55447));
            stops.Enqueue(new Position(9.99065, 53.55447));
            stops.Enqueue(new Position(9.99053, 53.55447));
            stops.Enqueue(new Position(9.99053, 53.55447));
            stops.Enqueue(new Position(9.98969, 53.55497));
            stops.Enqueue(new Position(9.98962, 53.555));
            stops.Enqueue(new Position(9.98957, 53.55503));
            stops.Enqueue(new Position(9.98951, 53.55505));
            stops.Enqueue(new Position(9.98942, 53.55509));
            stops.Enqueue(new Position(9.98931, 53.55513));
            stops.Enqueue(new Position(9.98923, 53.55516));
            stops.Enqueue(new Position(9.98919, 53.55517));
            stops.Enqueue(new Position(9.98901, 53.55522));
            stops.Enqueue(new Position(9.98892, 53.55525));
            stops.Enqueue(new Position(9.98843, 53.55539));
            stops.Enqueue(new Position(9.98824, 53.55544));
            stops.Enqueue(new Position(9.98814, 53.55547));
            stops.Enqueue(new Position(9.98807, 53.55549));
            stops.Enqueue(new Position(9.98802, 53.55551));
            stops.Enqueue(new Position(9.98802, 53.55551));
            stops.Enqueue(new Position(9.98802, 53.55551));
            stops.Enqueue(new Position(9.98797, 53.55553));
            stops.Enqueue(new Position(9.98791, 53.55556));
            stops.Enqueue(new Position(9.98787, 53.55559));
            stops.Enqueue(new Position(9.98782, 53.55563));
            stops.Enqueue(new Position(9.98777, 53.55568));
            stops.Enqueue(new Position(9.98777, 53.55568));
            stops.Enqueue(new Position(9.98775, 53.55572));
            stops.Enqueue(new Position(9.98774, 53.55576));
            stops.Enqueue(new Position(9.98773, 53.55579));
            stops.Enqueue(new Position(9.98774, 53.55584));
            stops.Enqueue(new Position(9.98775, 53.5559));
            stops.Enqueue(new Position(9.98782, 53.55609));
            stops.Enqueue(new Position(9.98788, 53.55625));
            stops.Enqueue(new Position(9.98794, 53.55638));
            stops.Enqueue(new Position(9.98801, 53.5565));
            stops.Enqueue(new Position(9.98806, 53.55659));
            stops.Enqueue(new Position(9.98812, 53.55666));
            stops.Enqueue(new Position(9.98819, 53.55675));
            stops.Enqueue(new Position(9.98826, 53.55684));
            stops.Enqueue(new Position(9.98832, 53.55691));
            stops.Enqueue(new Position(9.98837, 53.55696));
            stops.Enqueue(new Position(9.98847, 53.55706));
            stops.Enqueue(new Position(9.98847, 53.55706));
            stops.Enqueue(new Position(9.9886, 53.55713));
            stops.Enqueue(new Position(9.98869, 53.55718));
            stops.Enqueue(new Position(9.98872, 53.5572));
            stops.Enqueue(new Position(9.98874, 53.55722));
            stops.Enqueue(new Position(9.98876, 53.55724));
            stops.Enqueue(new Position(9.98877, 53.55726));
            stops.Enqueue(new Position(9.98879, 53.55729));
            stops.Enqueue(new Position(9.98885, 53.55743));
            stops.Enqueue(new Position(9.98892, 53.55756));
            stops.Enqueue(new Position(9.98909, 53.55793));
            stops.Enqueue(new Position(9.98911, 53.55798));
            stops.Enqueue(new Position(9.98918, 53.5581));
            stops.Enqueue(new Position(9.98931, 53.55831));
            stops.Enqueue(new Position(9.9894, 53.55844));
            stops.Enqueue(new Position(9.9894, 53.55844));
            stops.Enqueue(new Position(9.98954, 53.55854));
            stops.Enqueue(new Position(9.98967, 53.55874));
            stops.Enqueue(new Position(9.98975, 53.55893));
            stops.Enqueue(new Position(9.98995, 53.55926));
            stops.Enqueue(new Position(9.98995, 53.55926));
            stops.Enqueue(new Position(9.99, 53.55927));
            stops.Enqueue(new Position(9.99003, 53.55928));
            stops.Enqueue(new Position(9.99006, 53.5593));
            stops.Enqueue(new Position(9.99011, 53.55933));
            stops.Enqueue(new Position(9.99015, 53.55937));
            stops.Enqueue(new Position(9.99017, 53.5594));
            stops.Enqueue(new Position(9.99017, 53.55943));
            stops.Enqueue(new Position(9.99017, 53.55946));
            stops.Enqueue(new Position(9.99016, 53.55949));
            stops.Enqueue(new Position(9.99016, 53.55949));
            stops.Enqueue(new Position(9.99023, 53.5596));
            stops.Enqueue(new Position(9.99026, 53.55957));
            stops.Enqueue(new Position(9.99026, 53.55957));
            stops.Enqueue(new Position(9.99026, 53.55957));
            stops.Enqueue(new Position(9.99023, 53.5596));
            stops.Enqueue(new Position(9.99016, 53.55949));
            stops.Enqueue(new Position(9.99016, 53.55949));
            stops.Enqueue(new Position(9.99013, 53.55953));
            stops.Enqueue(new Position(9.99013, 53.55953));
            stops.Enqueue(new Position(9.99039, 53.55992));
            stops.Enqueue(new Position(9.99063, 53.56023));
            stops.Enqueue(new Position(9.99066, 53.56026));
            stops.Enqueue(new Position(9.99076, 53.56032));
            stops.Enqueue(new Position(9.99081, 53.56036));
            stops.Enqueue(new Position(9.99087, 53.5604));
            stops.Enqueue(new Position(9.99095, 53.56045));
            stops.Enqueue(new Position(9.99107, 53.56053));
            stops.Enqueue(new Position(9.99119, 53.56064));
            stops.Enqueue(new Position(9.99129, 53.56071));
            stops.Enqueue(new Position(9.99149, 53.56086));
            stops.Enqueue(new Position(9.99168, 53.56098));
            stops.Enqueue(new Position(9.99197, 53.56117));
            stops.Enqueue(new Position(9.99204, 53.56123));
            stops.Enqueue(new Position(9.99211, 53.56127));
            stops.Enqueue(new Position(9.99219, 53.56132));
            stops.Enqueue(new Position(9.99231, 53.56137));
            stops.Enqueue(new Position(9.99241, 53.56142));
            stops.Enqueue(new Position(9.9925, 53.56148));
            stops.Enqueue(new Position(9.99255, 53.56151));
            stops.Enqueue(new Position(9.99298, 53.56181));
            stops.Enqueue(new Position(9.99358, 53.56222));
            stops.Enqueue(new Position(9.99371, 53.56229));
            stops.Enqueue(new Position(9.99406, 53.56251));
            stops.Enqueue(new Position(9.9941, 53.56253));
            stops.Enqueue(new Position(9.99418, 53.56261));
            stops.Enqueue(new Position(9.99436, 53.56283));
            stops.Enqueue(new Position(9.99445, 53.56295));
            stops.Enqueue(new Position(9.99449, 53.56301));
            stops.Enqueue(new Position(9.99453, 53.56314));
            stops.Enqueue(new Position(9.99457, 53.5635));
            stops.Enqueue(new Position(9.99458, 53.56354));
            stops.Enqueue(new Position(9.99459, 53.5639));
            stops.Enqueue(new Position(9.99461, 53.56424));
            stops.Enqueue(new Position(9.99463, 53.56452));
            stops.Enqueue(new Position(9.99465, 53.56474));
            stops.Enqueue(new Position(9.99468, 53.56479));
            stops.Enqueue(new Position(9.9947, 53.56482));
            stops.Enqueue(new Position(9.99477, 53.56489));
            stops.Enqueue(new Position(9.99477, 53.56489));
            stops.Enqueue(new Position(9.99455, 53.56488));
            stops.Enqueue(new Position(9.99455, 53.56488));
            stops.Enqueue(new Position(9.99458, 53.56495));
            stops.Enqueue(new Position(9.99461, 53.56499));
            stops.Enqueue(new Position(9.99474, 53.56515));
            stops.Enqueue(new Position(9.99488, 53.56531));
            stops.Enqueue(new Position(9.99505, 53.56553));
            stops.Enqueue(new Position(9.99515, 53.56568));
            stops.Enqueue(new Position(9.99521, 53.56577));
            stops.Enqueue(new Position(9.99585, 53.56659));
            stops.Enqueue(new Position(9.99587, 53.56662));
            stops.Enqueue(new Position(9.99591, 53.56677));
            stops.Enqueue(new Position(9.99593, 53.56686));
            stops.Enqueue(new Position(9.99593, 53.56696));
            stops.Enqueue(new Position(9.99592, 53.56699));
            stops.Enqueue(new Position(9.99575, 53.56763));
            stops.Enqueue(new Position(9.99563, 53.56795));
            stops.Enqueue(new Position(9.99555, 53.56828));
            stops.Enqueue(new Position(9.99553, 53.56834));
            stops.Enqueue(new Position(9.99549, 53.5685));
            stops.Enqueue(new Position(9.99548, 53.56853));
            stops.Enqueue(new Position(9.99546, 53.56862));
            stops.Enqueue(new Position(9.99543, 53.56872));
            stops.Enqueue(new Position(9.99542, 53.56878));
            stops.Enqueue(new Position(9.99524, 53.56962));
            stops.Enqueue(new Position(9.99523, 53.5698));
            stops.Enqueue(new Position(9.99521, 53.56993));
            stops.Enqueue(new Position(9.99516, 53.57033));
            stops.Enqueue(new Position(9.99515, 53.57037));
            stops.Enqueue(new Position(9.99515, 53.57044));
            stops.Enqueue(new Position(9.99512, 53.57056));
            stops.Enqueue(new Position(9.99511, 53.57066));
            stops.Enqueue(new Position(9.9951, 53.57072));
            stops.Enqueue(new Position(9.99506, 53.57084));
            stops.Enqueue(new Position(9.99489, 53.57123));
            stops.Enqueue(new Position(9.9948, 53.57141));
            stops.Enqueue(new Position(9.99455, 53.57183));
            stops.Enqueue(new Position(9.99432, 53.57222));
            stops.Enqueue(new Position(9.99427, 53.57232));
            stops.Enqueue(new Position(9.99422, 53.57239));
            stops.Enqueue(new Position(9.99414, 53.57254));
            stops.Enqueue(new Position(9.99398, 53.57281));
            stops.Enqueue(new Position(9.99366, 53.57337));
            stops.Enqueue(new Position(9.9935, 53.57363));
            stops.Enqueue(new Position(9.99337, 53.57382));
            stops.Enqueue(new Position(9.9933, 53.57395));
            stops.Enqueue(new Position(9.99306, 53.57439));
            stops.Enqueue(new Position(9.99301, 53.57455));
            stops.Enqueue(new Position(9.99298, 53.57478));
            stops.Enqueue(new Position(9.99298, 53.57501));
            stops.Enqueue(new Position(9.99297, 53.5751));
            stops.Enqueue(new Position(9.99299, 53.57536));
            stops.Enqueue(new Position(9.99302, 53.57546));
            stops.Enqueue(new Position(9.99304, 53.57558));
            stops.Enqueue(new Position(9.99305, 53.57563));
            stops.Enqueue(new Position(9.99309, 53.57581));
            stops.Enqueue(new Position(9.9931, 53.57584));
            stops.Enqueue(new Position(9.99325, 53.57632));
            stops.Enqueue(new Position(9.99327, 53.57639));
            stops.Enqueue(new Position(9.99338, 53.5767));
            stops.Enqueue(new Position(9.9934, 53.57676));
            stops.Enqueue(new Position(9.99343, 53.57684));
            stops.Enqueue(new Position(9.99356, 53.57726));
            stops.Enqueue(new Position(9.99364, 53.5776));
            stops.Enqueue(new Position(9.99366, 53.57771));
            stops.Enqueue(new Position(9.99369, 53.57781));
            stops.Enqueue(new Position(9.99369, 53.57784));
            stops.Enqueue(new Position(9.99369, 53.57784));
            stops.Enqueue(new Position(9.99369, 53.57784));
            stops.Enqueue(new Position(9.99373, 53.57801));
            stops.Enqueue(new Position(9.99385, 53.57873));
            stops.Enqueue(new Position(9.99392, 53.57922));
            stops.Enqueue(new Position(9.99392, 53.57922));
            stops.Enqueue(new Position(9.99395, 53.57934));
            stops.Enqueue(new Position(9.99399, 53.57951));
            stops.Enqueue(new Position(9.994, 53.57958));
            stops.Enqueue(new Position(9.99402, 53.5796));
            stops.Enqueue(new Position(9.99402, 53.5796));
            stops.Enqueue(new Position(9.99404, 53.57961));
            stops.Enqueue(new Position(9.99406, 53.57961));
            stops.Enqueue(new Position(9.99407, 53.57962));
            stops.Enqueue(new Position(9.99409, 53.57963));
            stops.Enqueue(new Position(9.9941, 53.57965));
            stops.Enqueue(new Position(9.99411, 53.57966));
            stops.Enqueue(new Position(9.99411, 53.57967));
            stops.Enqueue(new Position(9.99411, 53.57968));
            stops.Enqueue(new Position(9.99411, 53.5797));
            stops.Enqueue(new Position(9.99411, 53.57971));
            stops.Enqueue(new Position(9.9941, 53.57972));
            stops.Enqueue(new Position(9.99409, 53.57974));
            stops.Enqueue(new Position(9.99408, 53.57975));
            stops.Enqueue(new Position(9.99407, 53.57976));
            stops.Enqueue(new Position(9.99407, 53.57976));
            stops.Enqueue(new Position(9.99411, 53.57985));
            stops.Enqueue(new Position(9.99415, 53.58004));
            stops.Enqueue(new Position(9.9947, 53.58148));
            stops.Enqueue(new Position(9.99475, 53.58162));
            stops.Enqueue(new Position(9.99475, 53.58162));
            stops.Enqueue(new Position(9.99473, 53.58178));
            stops.Enqueue(new Position(9.99435, 53.58215));
            stops.Enqueue(new Position(9.99403, 53.58256));
            stops.Enqueue(new Position(9.99393, 53.58279));
            stops.Enqueue(new Position(9.99393, 53.58279));
            stops.Enqueue(new Position(9.99395, 53.58284));
            stops.Enqueue(new Position(9.99393, 53.58302));
            stops.Enqueue(new Position(9.99392, 53.58308));
            stops.Enqueue(new Position(9.99391, 53.58314));
            stops.Enqueue(new Position(9.99391, 53.58314));
            stops.Enqueue(new Position(9.99394, 53.58315));
            stops.Enqueue(new Position(9.99396, 53.58317));
            stops.Enqueue(new Position(9.99397, 53.58319));
            stops.Enqueue(new Position(9.99398, 53.58322));
            stops.Enqueue(new Position(9.99398, 53.58322));
            stops.Enqueue(new Position(9.99413, 53.58326));
            stops.Enqueue(new Position(9.99461, 53.58343));
            stops.Enqueue(new Position(9.99465, 53.58348));
            stops.Enqueue(new Position(9.99487, 53.58354));
            stops.Enqueue(new Position(9.99505, 53.58357));
            stops.Enqueue(new Position(9.99505, 53.58357));
            stops.Enqueue(new Position(9.99529, 53.58364));
            stops.Enqueue(new Position(9.99572, 53.58379));
            stops.Enqueue(new Position(9.99583, 53.58384));
            stops.Enqueue(new Position(9.99593, 53.58386));
            stops.Enqueue(new Position(9.99609, 53.58391));
            stops.Enqueue(new Position(9.99711, 53.58428));
            stops.Enqueue(new Position(9.9973, 53.58435));
            stops.Enqueue(new Position(9.99803, 53.58465));
            stops.Enqueue(new Position(9.99817, 53.58471));
            stops.Enqueue(new Position(9.99828, 53.58476));
            stops.Enqueue(new Position(9.99941, 53.58524));
            stops.Enqueue(new Position(9.99952, 53.58529));
            stops.Enqueue(new Position(9.99969, 53.58536));
            stops.Enqueue(new Position(9.99992, 53.58547));
            stops.Enqueue(new Position(10.00126, 53.58617));
            stops.Enqueue(new Position(10.00165, 53.58639));
            stops.Enqueue(new Position(10.00195, 53.58658));
            stops.Enqueue(new Position(10.00218, 53.58671));
            stops.Enqueue(new Position(10.00237, 53.58684));
            stops.Enqueue(new Position(10.00248, 53.58693));
            stops.Enqueue(new Position(10.00254, 53.58698));
            stops.Enqueue(new Position(10.00275, 53.58714));
            stops.Enqueue(new Position(10.00275, 53.58714));
            stops.Enqueue(new Position(10.00272, 53.58717));
            stops.Enqueue(new Position(10.00272, 53.58717));
            stops.Enqueue(new Position(10.00272, 53.58717));
            stops.Enqueue(new Position(10.00275, 53.58714));
            stops.Enqueue(new Position(10.00283, 53.58703));
            stops.Enqueue(new Position(10.00286, 53.587));
            stops.Enqueue(new Position(10.00295, 53.58687));
            stops.Enqueue(new Position(10.00307, 53.58669));
            stops.Enqueue(new Position(10.00314, 53.58659));
            stops.Enqueue(new Position(10.00342, 53.58623));
            stops.Enqueue(new Position(10.00363, 53.58596));
            stops.Enqueue(new Position(10.00376, 53.58579));
            stops.Enqueue(new Position(10.00404, 53.58542));
            stops.Enqueue(new Position(10.00423, 53.58518));
            stops.Enqueue(new Position(10.00464, 53.58463));
            stops.Enqueue(new Position(10.00525, 53.58382));
            stops.Enqueue(new Position(10.00551, 53.58347));
            stops.Enqueue(new Position(10.00558, 53.58338));
            stops.Enqueue(new Position(10.00564, 53.58329));
            stops.Enqueue(new Position(10.00618, 53.5826));
            stops.Enqueue(new Position(10.00623, 53.58254));
            stops.Enqueue(new Position(10.00626, 53.5825));
            stops.Enqueue(new Position(10.00628, 53.58247));
            stops.Enqueue(new Position(10.00733, 53.58108));
            stops.Enqueue(new Position(10.00737, 53.58102));
            stops.Enqueue(new Position(10.00746, 53.58091));
            stops.Enqueue(new Position(10.00755, 53.58079));
            stops.Enqueue(new Position(10.00757, 53.58076));
            stops.Enqueue(new Position(10.00825, 53.57987));
            stops.Enqueue(new Position(10.00836, 53.57973));
            stops.Enqueue(new Position(10.0084, 53.57969));
            stops.Enqueue(new Position(10.00935, 53.57841));
            stops.Enqueue(new Position(10.00938, 53.57837));
            stops.Enqueue(new Position(10.00945, 53.57827));
            stops.Enqueue(new Position(10.00953, 53.57817));
            stops.Enqueue(new Position(10.00957, 53.57812));
            stops.Enqueue(new Position(10.00966, 53.57801));
            stops.Enqueue(new Position(10.00992, 53.57761));
            stops.Enqueue(new Position(10.00992, 53.57761));
            stops.Enqueue(new Position(10.01008, 53.57739));
            stops.Enqueue(new Position(10.01017, 53.57727));
            stops.Enqueue(new Position(10.01035, 53.57698));
            stops.Enqueue(new Position(10.01051, 53.57676));
            stops.Enqueue(new Position(10.01108, 53.57594));
            stops.Enqueue(new Position(10.01115, 53.57583));
            stops.Enqueue(new Position(10.01121, 53.57573));
            stops.Enqueue(new Position(10.01128, 53.57563));
            stops.Enqueue(new Position(10.01135, 53.57554));
            stops.Enqueue(new Position(10.01138, 53.57549));
            stops.Enqueue(new Position(10.01153, 53.57527));
            stops.Enqueue(new Position(10.012, 53.57458));
            stops.Enqueue(new Position(10.01205, 53.5745));
            stops.Enqueue(new Position(10.01213, 53.57438));
            stops.Enqueue(new Position(10.0122, 53.57429));
            stops.Enqueue(new Position(10.01225, 53.57422));
            stops.Enqueue(new Position(10.01284, 53.57336));
            stops.Enqueue(new Position(10.01316, 53.57289));
            stops.Enqueue(new Position(10.01326, 53.57275));
            stops.Enqueue(new Position(10.01393, 53.57177));
            stops.Enqueue(new Position(10.01393, 53.57177));
            stops.Enqueue(new Position(10.01393, 53.57177));
            stops.Enqueue(new Position(10.01404, 53.57162));
            stops.Enqueue(new Position(10.01406, 53.57158));
            stops.Enqueue(new Position(10.01411, 53.5715));
            stops.Enqueue(new Position(10.01418, 53.5714));
            stops.Enqueue(new Position(10.01422, 53.57134));
            stops.Enqueue(new Position(10.0143, 53.57123));
            stops.Enqueue(new Position(10.01517, 53.56996));
            stops.Enqueue(new Position(10.01609, 53.56861));
            stops.Enqueue(new Position(10.01618, 53.56849));
            stops.Enqueue(new Position(10.01624, 53.56835));
            stops.Enqueue(new Position(10.01639, 53.5676));
            stops.Enqueue(new Position(10.01639, 53.5676));
            stops.Enqueue(new Position(10.01634, 53.56753));
            stops.Enqueue(new Position(10.01639, 53.56718));
            stops.Enqueue(new Position(10.01631, 53.56691));
            stops.Enqueue(new Position(10.01641, 53.56633));
            stops.Enqueue(new Position(10.01643, 53.56626));
            stops.Enqueue(new Position(10.01647, 53.56611));
            stops.Enqueue(new Position(10.01652, 53.56602));
            stops.Enqueue(new Position(10.01659, 53.56587));
            stops.Enqueue(new Position(10.01661, 53.56584));
            stops.Enqueue(new Position(10.01667, 53.56575));
            stops.Enqueue(new Position(10.01676, 53.5653));
            stops.Enqueue(new Position(10.01673, 53.56512));
            stops.Enqueue(new Position(10.01664, 53.56463));
            stops.Enqueue(new Position(10.01654, 53.56432));
            stops.Enqueue(new Position(10.01643, 53.5641));
            stops.Enqueue(new Position(10.0161, 53.56371));
            stops.Enqueue(new Position(10.01601, 53.56361));
            stops.Enqueue(new Position(10.01587, 53.56353));
            stops.Enqueue(new Position(10.01577, 53.56347));
            stops.Enqueue(new Position(10.01571, 53.56343));
            stops.Enqueue(new Position(10.01503, 53.56294));
            stops.Enqueue(new Position(10.01491, 53.5628));
            stops.Enqueue(new Position(10.0148, 53.56268));
            stops.Enqueue(new Position(10.01469, 53.5626));
            stops.Enqueue(new Position(10.01469, 53.5626));
            stops.Enqueue(new Position(10.01463, 53.56251));
            stops.Enqueue(new Position(10.01454, 53.5624));
            stops.Enqueue(new Position(10.01436, 53.56218));
            stops.Enqueue(new Position(10.01419, 53.56201));
            stops.Enqueue(new Position(10.01394, 53.56181));
            stops.Enqueue(new Position(10.0137, 53.56163));
            stops.Enqueue(new Position(10.01346, 53.56148));
            stops.Enqueue(new Position(10.01321, 53.56134));
            stops.Enqueue(new Position(10.01304, 53.56123));
            stops.Enqueue(new Position(10.01295, 53.56117));
            stops.Enqueue(new Position(10.01291, 53.56112));
            stops.Enqueue(new Position(10.01288, 53.56105));
            stops.Enqueue(new Position(10.01285, 53.56101));
            stops.Enqueue(new Position(10.01274, 53.56091));
            stops.Enqueue(new Position(10.01251, 53.56073));
            stops.Enqueue(new Position(10.01234, 53.56065));
            stops.Enqueue(new Position(10.01228, 53.56058));
            stops.Enqueue(new Position(10.01219, 53.56052));
            stops.Enqueue(new Position(10.01215, 53.5605));
            stops.Enqueue(new Position(10.01201, 53.56046));
            stops.Enqueue(new Position(10.01194, 53.56044));
            stops.Enqueue(new Position(10.01179, 53.56042));
            stops.Enqueue(new Position(10.01167, 53.56041));
            stops.Enqueue(new Position(10.01161, 53.56041));
            stops.Enqueue(new Position(10.01143, 53.56042));
            stops.Enqueue(new Position(10.01133, 53.56043));
            stops.Enqueue(new Position(10.01126, 53.56043));
            stops.Enqueue(new Position(10.01115, 53.56042));
            stops.Enqueue(new Position(10.01106, 53.56041));
            stops.Enqueue(new Position(10.01062, 53.56028));
            stops.Enqueue(new Position(10.01033, 53.56014));
            stops.Enqueue(new Position(10.01013, 53.56005));
            stops.Enqueue(new Position(10.00957, 53.55977));
            stops.Enqueue(new Position(10.00952, 53.55974));
            stops.Enqueue(new Position(10.00952, 53.55974));
            stops.Enqueue(new Position(10.00952, 53.55974));
            stops.Enqueue(new Position(10.00935, 53.55962));
            stops.Enqueue(new Position(10.00893, 53.5594));
            stops.Enqueue(new Position(10.00851, 53.55921));
            stops.Enqueue(new Position(10.0084, 53.55916));
            stops.Enqueue(new Position(10.00816, 53.55907));
            stops.Enqueue(new Position(10.00774, 53.5589));
            stops.Enqueue(new Position(10.00761, 53.55885));
            stops.Enqueue(new Position(10.00677, 53.5586));
            stops.Enqueue(new Position(10.00582, 53.55824));
            stops.Enqueue(new Position(10.00536, 53.5581));
            stops.Enqueue(new Position(10.00496, 53.55794));
            stops.Enqueue(new Position(10.00459, 53.5578));
            stops.Enqueue(new Position(10.00436, 53.55773));
            stops.Enqueue(new Position(10.00401, 53.55759));
            stops.Enqueue(new Position(10.00379, 53.55752));
            stops.Enqueue(new Position(10.00363, 53.55749));
            stops.Enqueue(new Position(10.00347, 53.55747));
            stops.Enqueue(new Position(10.00333, 53.55746));
            stops.Enqueue(new Position(10.00218, 53.55744));
            stops.Enqueue(new Position(10.00218, 53.55744));
            stops.Enqueue(new Position(10.00216, 53.55735));
            stops.Enqueue(new Position(10.00215, 53.55731));
            stops.Enqueue(new Position(10.00211, 53.55719));
            stops.Enqueue(new Position(10.00208, 53.55713));
            stops.Enqueue(new Position(10.00204, 53.55709));
            stops.Enqueue(new Position(10.00202, 53.55707));
            stops.Enqueue(new Position(10.002, 53.55706));
            stops.Enqueue(new Position(10.00198, 53.55705));
            stops.Enqueue(new Position(10.00185, 53.55696));
            stops.Enqueue(new Position(10.00172, 53.55686));
            stops.Enqueue(new Position(10.00141, 53.55671));
            stops.Enqueue(new Position(10.00135, 53.55669));
            stops.Enqueue(new Position(10.00086, 53.55649));
            stops.Enqueue(new Position(10.00079, 53.55646));
            stops.Enqueue(new Position(10.00072, 53.55643));
            stops.Enqueue(new Position(10.00065, 53.55637));
            stops.Enqueue(new Position(10.00063, 53.55636));
            stops.Enqueue(new Position(10.00065, 53.5563));
            stops.Enqueue(new Position(10.0007, 53.55613));
            stops.Enqueue(new Position(10.0007, 53.55613));
            stops.Enqueue(new Position(10.00069, 53.55608));
            stops.Enqueue(new Position(10.00066, 53.55598));
            stops.Enqueue(new Position(10.00064, 53.55593));
            stops.Enqueue(new Position(10.00063, 53.55589));
            stops.Enqueue(new Position(10.0006, 53.55583));
            stops.Enqueue(new Position(10.00051, 53.5557));
            stops.Enqueue(new Position(10.00043, 53.55559));
            stops.Enqueue(new Position(10.00037, 53.55551));
            stops.Enqueue(new Position(10.00034, 53.55547));
            stops.Enqueue(new Position(10.00029, 53.55542));
            stops.Enqueue(new Position(10.00019, 53.55532));
            stops.Enqueue(new Position(10.00013, 53.55528));
            stops.Enqueue(new Position(9.99983, 53.55509));
            stops.Enqueue(new Position(9.99964, 53.55497));
            stops.Enqueue(new Position(9.99891, 53.55451));
            stops.Enqueue(new Position(9.998, 53.55395));
            stops.Enqueue(new Position(9.99753, 53.55367));
            stops.Enqueue(new Position(9.99707, 53.55338));
            stops.Enqueue(new Position(9.99661, 53.5531));
            stops.Enqueue(new Position(9.99657, 53.55307));
            stops.Enqueue(new Position(9.99645, 53.553));
            stops.Enqueue(new Position(9.99633, 53.55293));
            stops.Enqueue(new Position(9.99566, 53.55251));
            stops.Enqueue(new Position(9.99556, 53.55246));
            stops.Enqueue(new Position(9.99556, 53.55246));
            stops.Enqueue(new Position(9.99556, 53.55246));
            stops.Enqueue(new Position(9.99551, 53.55243));
            stops.Enqueue(new Position(9.99542, 53.55237));
            stops.Enqueue(new Position(9.99514, 53.55222));
            stops.Enqueue(new Position(9.99502, 53.55217));
            stops.Enqueue(new Position(9.9949, 53.55213));
            stops.Enqueue(new Position(9.99481, 53.5521));
            stops.Enqueue(new Position(9.99473, 53.55209));
            stops.Enqueue(new Position(9.99473, 53.55209));
            stops.Enqueue(new Position(9.99467, 53.55209));
            stops.Enqueue(new Position(9.99462, 53.55209));
            stops.Enqueue(new Position(9.99458, 53.55209));
            stops.Enqueue(new Position(9.99453, 53.5521));
            stops.Enqueue(new Position(9.99448, 53.55211));
            stops.Enqueue(new Position(9.99444, 53.55213));
            stops.Enqueue(new Position(9.99439, 53.55214));
            stops.Enqueue(new Position(9.99435, 53.55216));
            stops.Enqueue(new Position(9.994, 53.55238));
            stops.Enqueue(new Position(9.99384, 53.55249));
            stops.Enqueue(new Position(9.9938, 53.55251));
            stops.Enqueue(new Position(9.99376, 53.55254));
            stops.Enqueue(new Position(9.99329, 53.55284));
            stops.Enqueue(new Position(9.99322, 53.55289));
            stops.Enqueue(new Position(9.99279, 53.55317));
            stops.Enqueue(new Position(9.99231, 53.55348));
            stops.Enqueue(new Position(9.99182, 53.5538));
            stops.Enqueue(new Position(9.99182, 53.5538));
            stops.Enqueue(new Position(9.99185, 53.55382));
            stops.Enqueue(new Position(9.99193, 53.55386));
            stops.Enqueue(new Position(9.99193, 53.55386));
            stops.Enqueue(new Position(9.99187, 53.5539));
            stops.Enqueue(new Position(9.99187, 53.5539));

            return stops;
        }
    }
}