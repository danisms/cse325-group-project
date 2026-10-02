# Discourse — Brand and UI Style Guide

A practical design guide for the D Discourse web application: a platform where users can sign in, publish articles, and start or join discussions around articles.

## 1. Brand direction

**Product name:** D Discourse  
**Brand idea:** Read · Write · Discuss

Discourse should feel professional, readable, modern, and welcoming. The visual identity will support thoughtful writing and meaningful discussion without being overly flashy.

### Logo usage

Use the blue “D” chat-bubble symbol as the standalone logo for:

- Browser favicon
- App or mobile icon
- Compact sidebar branding
- Small spaces where the full wordmark will not fit

Use the symbol together with the **Discourse** wordmark for:

- The landing page
- Sign-in and account-creation pages
- Website header
- Project documentation and presentations

Keep the symbol and wordmark visually consistent. Export both logo versions as **SVG** for scalable web use and transparent PNG for contexts that need raster images.

## 2. Color palette

The palette is built around the blue logo, supported by navy text, light surfaces, and restrained green accents.

| Role            | Color           | Hex       | Recommended use                                                                    |
| --------------- | --------------- | --------- | ---------------------------------------------------------------------------------- |
| Primary blue    | Blue            | `#2563EB` | Primary buttons, links, active navigation, selected tabs, and interactive elements |
| Primary hover   | Darker blue     | `#1D4ED8` | Hover and pressed states for primary blue buttons                                  |
| Navy            | Deep navy       | `#0B1F3A` | Headings, main text, wordmark, and strong visual contrast                          |
| Success green   | Green           | `#15803D` | Publish actions, success states, and confirmations                                 |
| Success light   | Pale green      | `#DCFCE7` | Subtle success backgrounds                                                         |
| Page background | Cool light grey | `#F1F5F9` | Overall page background                                                            |
| Surface         | White           | `#FFFFFF` | Article cards, editor panels, navigation panels, and modals                        |
| Border          | Light grey      | `#E2E8F0` | Card borders, dividers, input borders, and separators                              |
| Muted text      | Slate grey      | `#64748B` | Author names, timestamps, descriptions, and secondary labels                       |

### Color usage principles

- Keep **blue** as the main brand and interaction color.
- Use **navy** for readable headings and body text.
- Reserve **green** for publishing, success, and confirmation actions. Do not use it everywhere.
- Use the light grey background to distinguish white cards and panels.
- Use muted grey for secondary information, not for important instructions or essential content.
- For normal-sized button text, use white on the darker green `#15803D` rather than the lighter `#16A34A` to improve contrast.
- Check text/background contrast before shipping the interface. Do not rely on color alone to communicate errors, success, or selection.

## 3. Typography

### Recommended typeface: Inter

Use **Inter** throughout the application. It is a clean, modern sans-serif typeface suitable for dashboards, forms, article interfaces, and long-form reading.

- Google Fonts: <https://fonts.google.com/specimen/Inter>
- Use one font family across the interface for consistency.
- Suggested weights:
    - `400` — Regular, for body text and article content
    - `500` — Medium, for navigation and controls
    - `600` — Semibold, for article titles and section headings
    - `700` — Bold, for major headings

### Suggested type sizes

| UI element                    | Font size |    Weight |
| ----------------------------- | --------: | --------: |
| Main page heading             | `28–32px` |     `700` |
| Article title                 | `20–24px` |     `600` |
| Section heading               |    `18px` |     `600` |
| Body and article text         |    `16px` |     `400` |
| Navigation labels and buttons | `14–15px` | `500–600` |
| Author names and timestamps   |    `13px` |     `400` |

### Article readability

For the article-reading page:

- Use a body line-height of around `1.7`.
- Keep the main article text column approximately `680–760px` wide on desktop.
- Avoid overly long lines of text.
- Preserve comfortable spacing between paragraphs, headings, lists, images, and blockquotes.
- On small screens, let the article column use the available width with consistent side padding.

## 4. UI design principles

### Overall look

Use a light, spacious interface with:

- Cool light-grey page backgrounds
- White cards and content surfaces
- Rounded corners
- Subtle borders
- Clear visual hierarchy
- Consistent spacing
- Blue interactive elements
- Minimal decorative effects

Avoid excessive gradients, shadows, bright colors, and unnecessary animations. The content and discussions should remain the focus.

### Suggested component styling

| Component         | Recommendation                                           |
| ----------------- | -------------------------------------------------------- |
| Cards             | White background, `1px` light-grey border, `12px` radius |
| Buttons           | Clear labels, medium/semi-bold text, `8px` radius        |
| Inputs            | White background, visible border, clear focus state      |
| Links             | Primary blue, with a visible hover/focus state           |
| Active navigation | Pale blue background with blue icon and text             |
| Tags/categories   | Subtle tinted backgrounds and readable text              |
| Dividers          | Light-grey border                                        |
| Dialogs/modals    | White surface, clear heading, distinct primary action    |

Treat these as starting points rather than rigid rules. Maintain consistency across the application.

## 5. Example interface layout

### Main dashboard

A desktop dashboard could use three areas:

1. **Left sidebar**
    - Discourse logo
    - Home
    - Explore
    - My Articles
    - Discussions
    - Notifications
    - Create Article
    - User profile

2. **Main content**
    - Search field
    - Welcome or introductory banner
    - Latest articles
    - Article cards with category, title, excerpt, author, date, and comment count

3. **Right sidebar**
    - Start a new article / Write Article panel
    - Trending topics
    - Popular discussions

On smaller screens, simplify or collapse the sidebars and prioritize the article feed.

### Article card

An article card can contain:

- Optional thumbnail
- Category tag
- Article title
- Short excerpt
- Author name and avatar
- Publication date or reading time
- Comment count

Keep the title prominent and make the card easy to scan. Avoid displaying too much metadata.

### Article reading page

Prioritize reading:

- Article title and category
- Author and publication details
- Article content in a centered, readable column
- Clear comment/discussion section
- A visible action to join the discussion
- Convenient access to related articles

### Article editor

The editor should feel calm and focused:

- Title field at the top
- Category selector
- Main writing area
- Clear save-draft and publish actions
- Helpful validation messages
- Confirmation before discarding substantial unsaved work, where appropriate

Do not make the editor visually crowded with secondary controls.

### Discussion threads

Make conversations easy to follow:

- Visually distinguish each comment
- Show the author and timestamp
- Make reply actions clear
- Use consistent indentation for replies
- Provide clear empty states when there are no comments yet
- Make keyboard focus and interactive states visible

## 6. Accessibility and responsive design

- Ensure sufficient color contrast for text, controls, and icons.
- Do not use color alone to communicate status; include text or an icon where appropriate.
- Provide visible keyboard-focus states.
- Use meaningful labels for form fields and buttons.
- Give informative images appropriate alternative text; use empty alt text for purely decorative images.
- Make buttons and interactive targets comfortable to use on touch screens.
- Test the interface at mobile, tablet, and desktop widths.
- Respect reduced-motion preferences if animations are used.
- Use semantic HTML elements and maintain a logical heading hierarchy.

## 7. CSS design tokens

The following CSS variables can serve as the foundation of the shared stylesheet.

```css
:root {
	/* Brand */
	--color-primary: #2563eb;
	--color-primary-hover: #1d4ed8;
	--color-navy: #0b1f3a;

	/* Actions */
	--color-success: #15803d;
	--color-success-light: #dcfce7;

	/* Surfaces */
	--color-background: #f1f5f9;
	--color-surface: #ffffff;
	--color-border: #e2e8f0;

	/* Text */
	--color-text: #0b1f3a;
	--color-text-muted: #64748b;

	/* Typography */
	--font-family: "Inter", sans-serif;
	--font-size-body: 16px;
	--line-height-body: 1.7;

	/* Shape */
	--radius-card: 12px;
	--radius-button: 8px;
}

body {
	font-family: var(--font-family);
	font-size: var(--font-size-body);
	line-height: var(--line-height-body);
	color: var(--color-text);
	background: var(--color-background);
}

button,
input,
textarea,
select {
	font: inherit;
}

button {
	cursor: pointer;
}

a {
	color: var(--color-primary);
}
```

### Loading Inter

If using Google Fonts, add this in the document `<head>`:

```html
<link rel="preconnect" href="https://fonts.googleapis.com" />
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
<link
	href="https://fonts.googleapis.com/css2?family=Inter:wght@400;500;600;700&display=swap"
	rel="stylesheet"
/>
```

If project will have a build setup that supports self-hosted fonts, then download and serve the font files locally.

## 8. Final Take

This combination is the baseline visual identity:

- **Brand symbol:** Blue D-shaped chat bubble
- **Primary color:** `#2563EB`
- **Main text/headings:** `#0B1F3A`
- **Success/publish color:** `#15803D`
- **Page background:** `#F1F5F9`
- **Card and panel background:** `#FFFFFF`
- **Secondary text:** `#64748B`
- **Typeface:** Inter
- **Card radius:** `12px`
- **Button radius:** `8px`
- **Article body:** `16px` with `1.7` line-height

Use these values consistently across the landing page, authentication pages, dashboard, article editor, article-reading page, and discussion threads. Note, this guide is a starting design system, which can be refined as needed.
