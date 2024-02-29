# Proyecto de Colas

Introducci�n:
El presente proyecto consiste en el desarrollo de un sistema de gesti�n de emergencias m�dicas utilizando el paradigma de 
teor�a de colas implementado en C#. El sistema estar� dise�ado para simular el comportamiento de un centro cl�nico donde 
llegan pacientes con diferentes niveles de prioridad. Se han considerado m�todos obligatorios como Remover, Insertar, 
Reacomodar, vac�a, llena para gestionar las colas de pacientes de manera eficiente. El sistema a desarrollar proporcionar� 
una herramienta eficaz para la gesti�n de emergencias m�dicas. La implementaci�n de la teor�a de colas permitir� organizar 
y priorizar la atenci�n de los pacientes de acuerdo con la gravedad de su condici�n. La divisi�n de m�dicos por especialidad 
asegura una atenci�n adecuada y oportuna a todos los pacientes, tanto ni�os como adultos.

Descripci�n del Sistema:
El sistema simula un centro cl�nico de emergencias donde los pacientes pueden llegar con diferentes niveles de prioridad. 
Se cuenta con un men� de opciones que permite realizar diversas operaciones, tales como insertar pacientes (la prioridad se 
generar� de forma aleatoria), remover pacientes de las colas de prioridad o colas normales, reacomodar las colas, y generar 
reportes del estado de las colas en cualquier�momento.

Prioridades de los Pacientes:
Los pacientes se dividen en dos categor�as: pacientes normales y pacientes con prioridad. Las prioridades se generan de forma 
aleatoria al momento de insertar un paciente en la cola. Las prioridades est�n jerarquizadas de la siguiente manera:

1. Accidentes aparatosos
2. Infartos
3. Afecciones respiratorias
4. Partos

Atenci�n M�dica:
Existen dos m�dicos disponibles para la atenci�n de los pacientes:
Un m�dico exclusivo para atender a ni�os.
Un m�dico para atender a los adultos.

Funcionamiento del Sistema:

1. Los pacientes se insertan en las colas seg�n su prioridad. Para la prioridad debe existir un m�todo que la genera de 
1. forma aleatoria a la hora de pulsar insertar, debe usar class random de c#
2. Los m�dicos atienden a los pacientes de acuerdo con su especializaci�n y disponibilidad.
3. Existe una opci�n en el men� para remover pacientes de las colas, considerando tanto las colas de prioridad como las colas 
1. normales. Este remover es la simulaci�n para atender un paciente
4. El sistema debe permitir reacomodar las colas para optimizar la atenci�n m�dica.
5. Se puede generar un reporte en cualquier momento para visualizar el estado de todas las colas y saber a qui�n se est� 
1. atendiendo en ese momento.

Cantidad de Participantes: 2 personas
Modalidad de Entrega: repositorio en github
Fecha de entrega: mi�rcoles 06 de Marzo
Fecha de Defensa: Jueves 07 (en la noche) marzo v�a google meet por equipo
