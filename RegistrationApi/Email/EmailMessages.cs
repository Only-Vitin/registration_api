namespace RegistrationApi.Email
{
    public struct EmailMessage
    {
        public static string CreateUserBody { get; set; } = 
        @"  
        <!DOCTYPE html>
        <html lang='pt-br'>
        <head>
            <meta charset='UTF-8'>
            <meta name='viewport' content='width=device-width, initial-scale=1.0'>
            <title>Validação de Cadastro - Mercado Pipipi</title>
            <style>
                body {
                    font-family: sans-serif;
                    margin: 0;
                    padding: 20px;
                    color: #333;
                }
                
                h1 {
                    font-size: 24px;
                    margin-top: 0;
                    text-align: left;
                }
                
                h3 {
                    font-size: 18px;
                    margin-top: 10px;
                    text-align: left;
                }
                
                button {
                    margin: 20px auto;
                    padding: 10px 20px;
                    font-size: 16px;
                    border: 1px solid #ccc;
                    border-radius: 5px;
                    cursor: pointer;
                    text-decoration: none;
                    color: #333;
                }
                
                button:hover {
                    background-color: #ddd;
                }
            </style>
        </head>
        <body>
            <h1>Validação de Cadastro - Mercado Pipipi</h1>
            <h3>Código: 5342.5321.7896</h3>
            <button>Clique aqui para validar</button>
        </body>
        </html>
        ";
    }
}
