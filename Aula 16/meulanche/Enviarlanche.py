import requests
import json

# Define o modelo do pedido como um dicionário
class Pedido:
    def __init__(self, cliente, item, quantidade, valor_total):
        self.cliente = cliente
        self.item = item
        self.quantidade = quantidade
        self.valor_total = valor_total

# Função principal
def main():
    # URL da API (ajuste conforme o endereço da API)
    api_url = "https://localhost:7260/api/pedido"

    # Solicita informações do pedido ao usuário
    cliente = input("Digite o nome do cliente: ")
    item = input("Digite o item do pedido: ")
    quantidade = int(input("Digite a quantidade: "))
    valor_total = float(input("Digite o valor total: "))

    # Cria um novo pedido
    novo_pedido = Pedido(cliente=cliente, item=item, quantidade=quantidade, valor_total=valor_total)

    # Converte o pedido para um dicionário para enviar como JSON
    pedido_dict = {
        "cliente": novo_pedido.cliente,
        "item": novo_pedido.item,
        "quantidade": novo_pedido.quantidade,
        "valorTotal": novo_pedido.valor_total
    }

    # Envia o pedido para a API (POST)
    try:
        response = requests.post(api_url, json=pedido_dict, verify=False)

        # Verifica se a requisição foi bem-sucedida
        if response.status_code == 200 or response.status_code == 201:
            print("Pedido enviado com sucesso!")
        else:
            print(f"Erro ao enviar o pedido. Status Code: {response.status_code}")
    except requests.exceptions.RequestException as e:
        print(f"Erro na conexão com a API: {e}")

if __name__ == "__main__":
    main()
