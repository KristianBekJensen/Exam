fun genList n =
    let
        fun loop n = fn acc ->
         (printStat 3;
          if n < 0 then acc else loop (n-1) (n::acc))
in
    printStat 2;
    loop n nil
end

begin
    printStat 1;
    genList 2
end