using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisA : Tetris {
    public TetrisA(int[,] map) : base(map) { }
}
public class TetrisB : Tetris {
    public TetrisB(int[,] map) : base(map) { }
}
public class TetrisC : Tetris {
    public TetrisC(int[,] map) : base(map) { }
}
public class TetrisD : Tetris {
    public TetrisD(int[,] map) : base(map) { }
}
public class TetrisE : Tetris {
    public TetrisE(int[,] map) : base(map) { }
}
public class TetrisS : Tetris {
    public TetrisS(int[,] map) : base(map) { }
}

public class TetrisA1 : TetrisA {
    public TetrisA1() : base(new int[1, 1] {
            { 1 }
        }) { }
}

public class TetrisB1 : TetrisB {
    public TetrisB1() : base(new int[1, 2] {
            {1, 1}
        }) { }
}

public class TetrisC1 : TetrisC {
    public TetrisC1() : base(new int[2, 2] {
            {0, 1},
            {1, 1}
        }) { }
}

public class TetrisC2 : TetrisC {
    public TetrisC2() : base(new int[1, 3] {
            {1, 1, 1}
        }) { }
}

public class TetrisD1 : TetrisD {
    public TetrisD1() : base(new int[2, 2] {
            {1, 1},
            {1, 1}
        }) { }
}

public class TetrisD2 : TetrisD {
    public TetrisD2() : base(new int[2, 3] {
            {0, 0, 1},
            {1, 1, 1}
        }) { }
}

public class TetrisD3 : TetrisD {
    public TetrisD3() : base(new int[2, 3] {
            {1, 1, 1},
            {0, 0, 1}
        }) { }
}

public class TetrisD4 : TetrisD {
    public TetrisD4() : base(new int[2, 3] {
            {0, 1, 0},
            {1, 1, 1}
        }) { }
}

public class TetrisD5 : TetrisD {
    public TetrisD5() : base(new int[2, 3] {
            {1, 1, 0},
            {0, 1, 1}
        }) { }
}

public class TetrisD6 : TetrisD {
    public TetrisD6() : base(new int[2, 3] {
            {0, 1, 1},
            {1, 1, 0}
        }) { }
}

public class TetrisD7 : TetrisD {
    public TetrisD7() : base(new int[1, 4] {
            {1, 1, 1, 1},
        }) { }
}

public class TetrisE1 : TetrisE {
    public TetrisE1() : base(new int[2, 3] {
            {0, 1, 1},
            {1, 1, 1}
        }) { }
}

public class TetrisE2 : TetrisE {
    public TetrisE2() : base(new int[2, 3] {
            {1, 1, 0},
            {1, 1, 1}
        }) { }
}

public class TetrisE3 : TetrisE {
    public TetrisE3() : base(new int[3, 3] {
            {1, 1, 1},
            {0, 1, 0},
            {0, 1, 0},
        }) { }
}

public class TetrisE4 : TetrisE {
    public TetrisE4() : base(new int[3, 3] {
            {0, 1, 0},
            {1, 1, 1},
            {0, 1, 0}
        }) { }
}

public class TetrisE5 : TetrisE {
    public TetrisE5() : base(new int[3, 3] {
            {1, 1, 0},
            {0, 1, 1},
            {0, 1, 0},
        }) { }
}

public class TetrisE6 : TetrisE {
    public TetrisE6() : base(new int[3, 3] {
            {0, 1, 1},
            {1, 1, 0},
            {0, 1, 0}
        }) { }
}

public class TetrisE7 : TetrisE {
    public TetrisE7() : base(new int[3, 3] {
            {0, 0, 1},
            {0, 1, 1},
            {1, 1, 0}
        }) { }
}

public class TetrisE8 : TetrisE {
    public TetrisE8() : base(new int[3, 3] {
            {0, 0, 1},
            {0, 0, 1},
            {1, 1, 1},
        }) { }
}

public class TetrisE9 : TetrisE {
    public TetrisE9() : base(new int[2, 3] {
            {1, 0, 1},
            {1, 1, 1}
        }) { }
}

public class TetrisE10 : TetrisE {
    public TetrisE10() : base(new int[2, 4] {
            {0, 1, 0, 0},
            {1, 1, 1, 1}
        }) { }
}

public class TetrisE11 : TetrisE {
    public TetrisE11() : base(new int[2, 4] {
            {0, 0, 1, 0},
            {1, 1, 1, 1}
        }) { }
}

public class TetrisE12 : TetrisE {
    public TetrisE12() : base(new int[2, 4] {
            {1, 1, 0, 0},
            {0, 1, 1, 1}
        }) { }
}

public class TetrisE13 : TetrisE {
    public TetrisE13() : base(new int[2, 4] {
            {0, 0, 1, 1},
            {1, 1, 1, 0}
        }) { }
}

public class TetrisE14 : TetrisE {
    public TetrisE14() : base(new int[2, 4] {
            {1, 0, 0, 0},
            {1, 1, 1, 1}
        }) { }
}

public class TetrisE15 : TetrisE {
    public TetrisE15() : base(new int[2, 4] {
            {0, 0, 0, 1},
            {1, 1, 1, 1}
        }) { }
}

public class TetrisE16 : TetrisE {
    public TetrisE16() : base(new int[1, 5] {
            {1, 1, 1, 1, 1},
        }) { }
}

public class TetrisE17 : TetrisE {
    public TetrisE17() : base(new int[3, 3] {
            {0, 1, 1},
            {0, 1, 0},
            {1, 1, 0}
        }) { }
}

public class TetrisE18 : TetrisE {
    public TetrisE18() : base(new int[3, 3] {
            {1, 1, 0},
            {0, 1, 0},
            {0, 1, 1}
        }) { }
}

public class TetrisS1 : TetrisS {
    public TetrisS1() : base(new int[2, 3] {
            {1, 1, 1},
            {1, 1, 1}
        }) { }
}

public class TetrisS2 : TetrisS {
    public TetrisS2() : base(new int[3, 3] {
            {0, 0, 1},
            {0, 1, 1},
            {1, 1, 1}
        }) { }
}

public class TetrisS3 : TetrisS {
    public TetrisS3() : base(new int[3, 3] {
            {0, 1, 0},
            {1, 1, 1},
            {1, 0, 1}
        }) { }
}