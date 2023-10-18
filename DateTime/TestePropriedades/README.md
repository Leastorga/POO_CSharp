# Algumas Propriedades

- Date (DateTime) = Fornece somento do dia
- Day (int) = Fornece o dia
- DayOfWeek (DayOfWeek) = Fornece o dia da semana
- DayOfYear (int) = Fornece o dia no ano
- Hour (int) = Fornece somente a hora
- Kind (DateTimeKind) = Fornece o fuso horário
- Millisecond (int) = Fornece o milissegundo
- Minute (int) = Fornece o minuto
- Month (int) = Fornece o mês
- Second (int) = Fornece o segundo
- Ticks (long) = Fornece os ticks (Nanosegundos)
- TimeOfDay (TimeSpan) = Fornece o horário do dia (duração do dia)
- Year (int) = Fornece o ano 

# Algumas funções

- ToLongDateString = Fornece o dia da semana e a data
- ToLongTimeString = Fornece o horário
- ToShortDateString = Fornece somente a data
- ToShortTimeString = Fornece o horário e o minuto
- ToString = So converte para string
- ToString(Mascara) = Fornece a data e horario de acordo com a mascara

# Algumas Operações

- DateTime y = x.Add(timeSpan);
- DateTime y = x.AddDays(double);
- DateTime y = x.AddHours(double);
- DateTime y = x.AddMilliseconds(double);
- DateTime y = x.AddMinutes(double);
- DateTime y = x.AddMonths(int);
- DateTime y = x.AddSeconds(double);
- DateTime y = x.AddTicks(long);
- DateTime y = x.AddYears(int);
- DateTime y = x.Subtract(timeSpan);
- TimeSpan t = x.Subtract(dateTime);
