
# BugTracker - ABM Usuarios


## Clonar Repositorio (Clone/Checkout)

**1. Ejecutar comando clone para descargar repositorio:** 
```sh
$ git clone https://github.com/utn-frc-pav1-3k5-2020/actividad_abm_usuarios.git
```
**2. Ubicarse en la carpeta generada con el nombre del repositorio: 

```sh
$ cd actividad_abm_usuarios
```

**3. Crear un nuevo branch (rama)**

Para crear una nueva rama (branch) y saltar a ella, en un solo paso, puedes utilizar el comando  `git checkout`  con la opción  `-b`, indicando el nombre del nuevo branch (reemplazando el nro de legajo) de la siguiente forma branch_{legajo}, para el legajo 12345:

```sh
$ git checkout -b branch_12345 
Switched to a new branch "12345"
```
Y para que se vea reflejada en GitHub:
```sh
$ git push --set-upstream origin branch_12345
```

## Actividad ABM Usuarios

> Iniciar la solución que se encuentra en la carpeta src/BugTracker.sln
Se agregaron 2 formularios. 
> - frmUsuario: Consulta los usuarios registrados con un filtro por "Nombre" y Perfil (que se elige de un combo)
> - frmABMUsuario: Permite hacer el Alta y Modificación de usuarios, que previamente se seleccionaron en frmUsuario.

Sobre el formulario `frmABMUsuario` realizar las siguientes actividades:

**1. Validar Campos Obligatorios.**
En el método ValidarCampos agregar las validaciones que faltan sobre los textbox:
* txtPassword
* txtConfirmarPass
* cboPerfil

**2. Actualizar Usuario.**
Implementar lógica en BusinessLayer y DataAccessLayer para actualizar los datos de un usuario.

**3. Eliminado lógico de Usuario.**
El borrado lógico consiste en utilizar una columna de la tabla de Usuarios (borrado: true/false) como una marca que indica si fue eliminado o no un elemento. 



## Versionar en GitHub los cambios locales (add / commit / push)

> A continuación vamos a crear el **commit** y subir los cambios al servidor GitHub.

1. **Status**. Verificamos los cambios pendientes de versionar.

```sh
$ git status
```

2. **Add**. Agregamos todos los archivos nuevos no versionados.

```sh
$ git add -A
```

3. **Commit**. Generamos un commit con todos los cambios y agregamos un comentario.

```sh
$ git commit -a -m "Comentario"
```

4. **Push**. Enviamos todos los commits locales a GitHub

```sh
$ git push
```

5. **Status**. Verificar que no quedaron cambios pendientes de versionar

```sh
$ git status
```
