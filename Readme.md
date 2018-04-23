# How to show a tooltip for time cells in a scheduler view


<p>Problem:</p><p>I'd like to add a general tooltip for the Scheduler control. It should be displayed when the user is hovering over the time cell area.</p><p>Solution:</p><p>Place the <strong>ToolTipController</strong> component onto a form. You should enable a tooltip for each visible cell in a View. To accomplish this, subscribe to the <strong>SelectionChanged</strong>, <strong>VisibleIntervalChanged</strong> and <strong>SizeChanged</strong> events of the Scheduler control. These events call the <strong>PrepareToolTipCell</strong>s routine. It sets the <strong>ShouldShowToolTip</strong> property to true and the <strong>ToolTipText</strong> to a non-empty text value for each cell in a cell container.<br />
Then, within the <strong>BeforeShow</strong> event of the ToolTipController, a text to display in a tooltip is specified.</p>

<br/>


