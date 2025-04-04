using core = Syncfusion.Maui.Toolkit.TextInputLayout;

namespace Syncfusion.Maui.ControlsGallery.TextInputLayout.SfTextInputLayout
{
	public partial class PaymentPageDesktop : SampleView
	{
		public PaymentPageDesktop()
		{
			InitializeComponent();
#if WINDOWS
			PayNameField.InputViewPadding = new Thickness(16, 2, 16, 2);
			CardNumberField.InputViewPadding = new Thickness(16, 2, 16, 2);
			CardNumberField1.InputViewPadding = new Thickness(16, 2, 16, 2);
			CardNumberField2.InputViewPadding = new Thickness(16, 2, 16, 2);
			CardNumberField3.InputViewPadding = new Thickness(16, 2, 16, 2);
			CVVField.InputViewPadding = new Thickness(16, 2, 16, 2);
			MonthField.InputViewPadding = new Thickness(16, 2, 2, 2);
			YearField.InputViewPadding = new Thickness(16, 2, 2, 2);
#else
			PayNameField.InputViewPadding = new Thickness(16, 8, 16, 8);
			CardNumberField.InputViewPadding = new Thickness(16, 8, 16, 8);
			CardNumberField1.InputViewPadding = new Thickness(16, 8, 16, 8);
			CardNumberField2.InputViewPadding = new Thickness(16, 8, 16, 8);
			CardNumberField3.InputViewPadding = new Thickness(16, 8, 16, 8);
			CVVField.InputViewPadding = new Thickness(16, 8, 16, 8);
			MonthField.InputViewPadding = new Thickness(16, 8, 16, 8);
			YearField.InputViewPadding = new Thickness(16, 8, 16, 8);
#endif
		}

		private void SubmitButton_Clicked(object sender, EventArgs e)
		{
			PaymentPageDesktop.FieldNullCheck(PayNameField);
			PaymentPageDesktop.FieldNullCheck(CardNumberField);
			PaymentPageDesktop.FieldNullCheck(CardNumberField1);
			PaymentPageDesktop.FieldNullCheck(CardNumberField2);
			PaymentPageDesktop.FieldNullCheck(CardNumberField3);
			PaymentPageDesktop.FieldNullCheck(CVVField);
			PaymentPageDesktop.FieldNullCheck(MonthField);
			PaymentPageDesktop.FieldNullCheck(YearField);
			ValidateCardNumber();
		}

		private static void FieldNullCheck(core.SfTextInputLayout inputLayout)
		{
			if (string.IsNullOrEmpty(inputLayout.Text))
			{
				inputLayout.HasError = true;
			}
			else
			{
				inputLayout.HasError = false;
			}
		}

		private void ValidateCardNumber()
		{
			if (CardNumberField.Text == null || CardNumberField.Text.Length != 4 || !double.TryParse(CardNumberField.Text, out _))
			{
				CardNumberField.HasError = true;
			}
			else
			{
				CardNumberField.HasError = false;
			}

			if (CardNumberField1.Text == null || CardNumberField1.Text.Length != 4 || !double.TryParse(CardNumberField1.Text, out _))
			{
				CardNumberField1.HasError = true;
			}
			else
			{
				CardNumberField1.HasError = false;
			}

			if (CardNumberField2.Text == null || CardNumberField2.Text.Length != 4 || !double.TryParse(CardNumberField2.Text, out _))
			{
				CardNumberField2.HasError = true;
			}
			else
			{
				CardNumberField2.HasError = false;
			}

			if (CardNumberField3.Text == null || CardNumberField3.Text.Length != 4 || !double.TryParse(CardNumberField3.Text, out _))
			{
				CardNumberField3.HasError = true;
			}
			else
			{
				CardNumberField3.HasError = false;
			}

			if (CVVField.Text == null || CVVField.Text.Length != 3 || !double.TryParse(CVVField.Text, out _))
			{
				CVVField.HasError = true;
			}
			else
			{
				CVVField.HasError = false;
			}

		}

		private void Entry_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (e.NewTextValue.Length == 4)
			{
				CardNumberField1.Focus();
			}
		}

		private void Entry2_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (e.NewTextValue.Length == 4)
			{
				CardNumberField2.Focus();
			}
		}

		private void Entry3_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (e.NewTextValue.Length == 4)
			{
				CardNumberField3.Focus();
			}
		}
	}
}