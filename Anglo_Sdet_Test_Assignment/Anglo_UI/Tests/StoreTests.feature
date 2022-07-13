Feature: Store

    Scenario: Search returns some results
        When I search by 'heel' criteria
        Then there are 2 search results
        And search results are the following
            | Item                                                                |
            | NEW LADIES HIGH WEDGE HEEL TOE THONG DIAMANTE FLIP FLOP SANDALS     |
            | WOMENS HIGH HEEL POINT TOE STILETTO SANDALS ANKLE STRAP COURT SHOES |

    Scenario: Add item to the cart
        When I search by 'veronica roth' criteria
        And I add opened item to the cart
        Then item in the cart is 'Allegiant by Veronica Roth'

    Scenario: Remove item from the cart
        When I search by 'veronica roth' criteria
        And I add opened item to the cart
        And I open my cart
        And I remove an item from the cart
        Then there is no 'Allegiant by Veronica Roth' item in the cart

    Scenario Outline: Verify category title
        When I open '<CategoryToOpen>' category from category menu
        Then the title of opened category is '<ExpectedCategoryTitle>'

        Examples:
            | CategoryToOpen | ExpectedCategoryTitle |
            | Skincare       | SKINCARE              |
            | Makeup         | MAKEUP                |