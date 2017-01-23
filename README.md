# GravatarTagHelpers
A simple tag helper to display the Gravatar image using email address.

## Setup
To use this tag helper, add the following line in ```_ViewImports.cshtml```.
```html
@addTagHelper *, GravatarTagHelpers
```

## Code

To get the gravatar image for email address "[example@test.com](mailto:example@test.com)", use the following syntax.

```html
<gravatar-img email="example@test.com" size="100"></gravatar-img>
```

## Output
```html
<img src="http://www.gravatar.com/avatar/29e3f53ee49fae541ee0f48fb712c231.jpg?s=100&d=identicon&r=g"/>
```

## License
[Apache 2.0](https://github.com/manojkulkarni30/GravatarTagHelpers/blob/master/License.txt)