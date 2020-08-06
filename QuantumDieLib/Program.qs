namespace PereyraGamboa.Quantum.QuantumDieLib {
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Measurement;
    
    @EntryPoint()
    operation QuantumDie () : Int {
        mutable res = 0;
        let theta = 2. * ArcTan(Sqrt(0.5));

        using (qs = Qubit[3]) {
            H(qs[0]);
            Rx(theta, qs[2]);
            X(qs[2]);
            Controlled H([qs[2]], qs[1]);
            X(qs[2]);

            let ms = MultiM(qs);
            if (ms[0] == One) { set res += 1; }
            if (ms[1] == One) { set res += 2; }
            if (ms[2] == One) { set res += 4; }
        }

        return res;
    }
}
