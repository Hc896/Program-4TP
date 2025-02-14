export const Input =( {colorNameProps, handleSubmit, handleInputChange } ) => {
    return (
        <div>
            <h2>Hello from Input component!</h2>

            <form onSubmit={handleSubmit}>
                <input 
                    autoFocus 
                    type="text"
                    placeholder='enter a color name'
                    required
                    value={colorNameProps}
                    onChange={handleInputChange}>

                </input>
            </form>
        </div>
    )
}