
            // Cria a biblioteca
            Biblioteca biblioteca = new Biblioteca();

            // Cria os livros
            Livro livro1 = new Livro("George Samuel Clason", "123456789", "Educação", 3, "O Homem Mais Rico da Babilônia", "001");
            Livro livro2 = new Livro("Robert Kiyosaki", "987654321", "Educação", 5, "Pai Rico, Pai Pobre", "002");

            // Cria os usuários
            Usuario usuario1 = new Usuario("Kailan", "123", "Rua A", "kailan@email.com");
            Usuario usuario2 = new Usuario("Maria Clara", "456", "Rua B", "maria@email.com");

            // Cadastra livros e usuários na biblioteca
            biblioteca.CadastrarLivro(livro1);
            biblioteca.CadastrarLivro(livro2);

            biblioteca.CadastrarUsuario(usuario1);
            biblioteca.CadastrarUsuario(usuario2);

            // lista todos os livros e usuários cadastrados
            Console.WriteLine("\nLivros cadastrados:");
            biblioteca.ListarLivros();

            Console.WriteLine("\nUsuários cadastrados:");
            biblioteca.ListarUsuarios();

            // pesquisa livro por título
            Console.WriteLine("\nPesquisar livro pelo título 'Pai,Rico, Pai Pobre':");
            List<Livro> livrosPesquisados = biblioteca.PesquisarLivrosPorTitulo("Pai Rico, Pai Pobre");
            foreach (var livro in livrosPesquisados)
            {
                Console.WriteLine($"Livro encontrado: {livro.Titulo}");
            }

            // Efetua o empréstimo de um livro
            Console.WriteLine("\nEmprestando livro 'Pai Rico, Pai Pobre' para Kailan...");
            biblioteca.EmprestarLivro("001", "123");
            Console.WriteLine("\nEmprestando livro 'O Homem Mais Rico da Babilônia' para Maria...");
            biblioteca.EmprestarLivro("002", "456");

            // Tenta efetuar o emprestimo sem estoque
            Console.WriteLine("\nTentativa de novo empréstimo sem estoque...");
            for (int i = 0; i < 3; i++) // Simulando esgotar o estoque
            {
                biblioteca.EmprestarLivro("001", "123");
            }

            // Devolve o livro
            Console.WriteLine("\nDevolvendo livro 'Pai Rico, Pai Pobre'...");
            biblioteca.DevolverLivro("001");

            // Mostra histórico de empréstimos do usuário
            Console.WriteLine("\nHistórico de empréstimos de Kailan:");
            usuario1.ExibirHistorico();
            Console.WriteLine("\nHistórico de empréstimos de Maria:");
            usuario1.ExibirHistorico();
   