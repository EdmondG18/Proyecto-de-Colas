# Proyecto de Colas

Introducción:
El presente proyecto consiste en el desarrollo de un sistema de gestión de emergencias médicas utilizando el paradigma de 
teoría de colas implementado en C#. El sistema estará diseñado para simular el comportamiento de un centro clínico donde 
llegan pacientes con diferentes niveles de prioridad. Se han considerado métodos obligatorios como Remover, Insertar, 
Reacomodar, vacía, llena para gestionar las colas de pacientes de manera eficiente. El sistema a desarrollar proporcionará 
una herramienta eficaz para la gestión de emergencias médicas. La implementación de la teoría de colas permitirá organizar 
y priorizar la atención de los pacientes de acuerdo con la gravedad de su condición. La división de médicos por especialidad 
asegura una atención adecuada y oportuna a todos los pacientes, tanto niños como adultos.

Descripción del Sistema:
El sistema simula un centro clínico de emergencias donde los pacientes pueden llegar con diferentes niveles de prioridad. 
Se cuenta con un menú de opciones que permite realizar diversas operaciones, tales como insertar pacientes (la prioridad se 
generará de forma aleatoria), remover pacientes de las colas de prioridad o colas normales, reacomodar las colas, y generar 
reportes del estado de las colas en cualquier momento.

Prioridades de los Pacientes:
Los pacientes se dividen en dos categorías: pacientes normales y pacientes con prioridad. Las prioridades se generan de forma 
aleatoria al momento de insertar un paciente en la cola. Las prioridades están jerarquizadas de la siguiente manera:

1. Accidentes aparatosos
2. Infartos
3. Afecciones respiratorias
4. Partos

Atención Médica:
Existen dos médicos disponibles para la atención de los pacientes:
Un médico exclusivo para atender a niños.
Un médico para atender a los adultos.

Funcionamiento del Sistema:

1. Los pacientes se insertan en las colas según su prioridad. Para la prioridad debe existir un método que la genera de 
1. forma aleatoria a la hora de pulsar insertar, debe usar class random de c#
2. Los médicos atienden a los pacientes de acuerdo con su especialización y disponibilidad.
3. Existe una opción en el menú para remover pacientes de las colas, considerando tanto las colas de prioridad como las colas 
1. normales. Este remover es la simulación para atender un paciente
4. El sistema debe permitir reacomodar las colas para optimizar la atención médica.
5. Se puede generar un reporte en cualquier momento para visualizar el estado de todas las colas y saber a quién se está 
1. atendiendo en ese momento.

Cantidad de Participantes: 2 personas
Modalidad de Entrega: repositorio en github
Fecha de entrega: miércoles 06 de Marzo
Fecha de Defensa: Jueves 07 (en la noche) marzo vía google meet por equipo
