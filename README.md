# My OpenFaas Templates

Forked from [Official OpenFaas Templates](https://github.com/openfaas/templates "Github OpenFaas templates"). I use these to run and deploy my own workloads on OpenFaas.

These also include the official OpenFaas Templates. New templates added are:

| Name | Language | Version | Watchdog   | Link
|:-----|:---------|:--------|:-----------|:---------
| csharp-http | C# | N/A | Of-Watchdog | [C# template](https://github.com/zeerorg/templates/tree/master/template/csharp-http)
| csharp-http-armhf | C# | N/A | Of-Watchdog | [C# ARM template](https://github.com/zeerorg/templates/tree/master/template/csharp-http-armhf)

## Some Info

1. New templates will be based on the newer [Of-Watchdog](https://github.com/openfaas-incubator/of-watchdog).
2. Every template will have armhf counterpart, since most of the time I need to deploy them to my raspberry-pi.
3. Try to make them in such a way that they are locally testable, ie they can be developed on the local machine.