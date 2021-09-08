

# BugTracker - ABM Usuarios


## Clonar Repositorio (Clone/Checkout)

**1. Ejecutar comando clone para descargar repositorio:** 
```sh
$ git clone https://github.com/utn-frc-pav1-3k5-2021/actividad_abm_usuarios.git
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

> Iniciar la solución que se encuentra en la carpeta src/BugTracker.sln.


Sobre el formulario `frmABMUsuario` realizar las siguientes actividades:

### 1. Agregar Menú Soporte-> Usuarios

* Agregar a  `frmPrincipal` el menú Soporte-> Usuarios, como se ve a continuación:

![frmPrincipal.png](https://github.com/utn-frc-pav1-3k5-2021/actividad_abm_usuarios/blob/main/img/frmPrincipal.png?raw=true)

* Agregar evento **click** del menú **Usuarios** que abra el formulario frmUsuarios. 

### 2. Formulario Usuarios

![frmUsuarios.png](https://github.com/utn-frc-pav1-3k5-2021/actividad_abm_usuarios/blob/main/img/frmUsuarios.png?raw=true)

* **Botón Consultar**
	* En el evento **click** de **btnConsultar** agregar código para obtener los usuarios de la base de datos, filtrando por Nombre y Perfil. Tener en cuenta que se encuentra disponible el método **oUsuarioService.ConsultarConFiltro(filters)**.
	* Si el **chkTodos** tiene la propiedad **chkTodos.Checked = true** obtener todos los usuarios sin filtrar y usar el método **oUsuarioService.ObtenerTodos()**.
	* Completar la grilla **dgvUsers** con los usuarios obtenidos.
	
* **Habilitar Botones Editar y Eliminar**
	- Al abrir el formulario **frmUsuarios** los botones **btnEditar** y **btnQuitar** deben estar deshabilitados. 
	- Al seleccionar un elemento de la grilla **dgvUsers**  (usar el evento **CellClick** ) habilitar los botones  **btnEditar** y **btnQuitar** (ej. btnEditar.Enabled = true).

* **Botón btnEditar**
	* En el evento **click** del botón **btnEditar**:
		* Crear un objeto de **frmABMUsuario**.
		* Ejecutar el método **InicializarFormulario()**.
		* Abrir el formulario con el método **ShowDialog()**.

* **Botón btnQuitar**
	* En el evento **click** del botón **btnQuitar**:
		* Crear un objeto de **frmABMUsuario**.
		* Ejecutar el método **InicializarFormulario()**.
		* Abrir el formulario con el método **ShowDialog()**.


### 3. Formulario ABM Usuarios

![frmABMUsuario.png](https://github.com/utn-frc-pav1-3k5-2021/actividad_abm_usuarios/blob/main/img/frmABMUsuario.png?raw=true)

> El formulario `frmABMUsuario`se debe utilizar para las 3 operaciones de administración de usuario: **A**lta / **B**aja / **M**odificación. Por lo tanto, el comportamiento del formulario depende del tipo de operación.
> En el formulario ya se encuentra desarrollada la lógica de **A**lta.

* **Botón Aceptar: Validar Campos Obligatorios**
En el método **ValidarCampos()** agregar las validaciones de campo obligatorio que faltan sobre los textbox:
	- txtPassword
	- txtConfirmarPass
	- cboPerfil

* **Ocultar Contraseña**
Sobre los textbox txtPassword y txtConfirmarPass indicar el valor * a la propiedad PasswordChar para ocultar los caracteres que se escriben en el textbox.

* **Actualizar Usuario**
Implementar lógica en BusinessLayer y DataAccessLayer para actualizar los datos de un usuario.

* **Eliminado lógico de Usuario**
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
