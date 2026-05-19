# 📱 Mobile Input Adapter

Asset para adaptação simples de jogos Unity para plataformas mobile, utilizando o novo **Input System** da Unity.

---

## Como funciona

O sistema detecta automaticamente a plataforma em que o jogo está rodando. Caso seja uma plataforma mobile, um canvas dedicado é ativado, exibindo os controles virtuais na tela.

Esse canvas contém botões com os componentes `OnScreenButton` ou `OnScreenStick`, prontos para uso em dispositivos móveis.

## Como usar

1. Adicione o asset à **primeira cena do jogo** (ou à cena principal onde o jogo ocorre).
2. O objeto possui `DontDestroyOnLoad` e persistirá durante toda a sessão.
3. **Remova-o de cenas onde os controles não devem aparecer**, como menus iniciais e telas de fim de jogo, que já possuem sua própria UI.

## Pré-requisitos

- **Input System** da Unity instalado no projeto (novo sistema de input).
- **TMPro** instalado no projeto.
- Inputs do jogador mapeados de acordo com o Input System.

> Os botões padrão incluídos (`Move`, `Jump` e `Pause`) utilizam o mesmo caminho de mapeamento do gamepad.

## Configuração

### `usesStick` (booleana)

No script do sistema, há uma variável chamada `usesStick` que controla o modo de movimentação exibido no mobile:

| Valor | Comportamento |
|-------|---------------|
| `false` (padrão) | Exibe dois botões: **Left** e **Right** |
| `true` | Exibe um **stick analógico** de movimentação |

**Ative `usesStick`** quando o jogo utilizar movimentação top-down ou qualquer outro esquema que permita movimento livre no plano cartesiano.