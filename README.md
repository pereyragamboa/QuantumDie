# QuantumDie

Implementations of a quantum algorith simulating a six-face die, based on the following circuit:

<img src="circuit.svg">

## IBM Quantum Experience

The circuit was designed using the Circuit Composer in [IBM Quantum Experience](https://quantum-computing.ibm.com/).
The file `QuantumDie.qasm` was exported from there, and it can be imported back into the Composer 
(click on **Code** for displaying the Code editor; then select **QASM**, click on the ellipsis and click on **Import code**).

For running the circuit, click on **Run Settings**, select and configure the backend where you want to run the circuit, 
and click on **Run on [backend name]**. This will append the circuit to the job queue of the selected backend.
The result should appear on the section **Pending results** of the Dashboard; 
when the job completes, it will appear on the section **Latest results**.

## Q# solution

The rest of this repo's content is a Visual Studio 2019 solution. 
For running it, install the [Microsoft Quantum Development Kit](https://docs.microsoft.com/en-us/quantum/quickstarts/install-command-line).

The folder `QuantumDieLib` contains the quantum algorithm simulating the die in Q#.
The folder `QuantumDieHost` contains a C# host executing the quantum algorithm in a QDK simulator.

It is possible to run either project. The Q# project will run the algorithm only once; 
the C# host will run the algorithm a default of 1000 times, but this can be changed by using command line arguments
(Project properties | Debug | Application arguments).