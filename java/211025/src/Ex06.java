import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JButton;
import java.awt.BorderLayout;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JTextField;
import javax.swing.JSplitPane;
import javax.swing.JTable;
import javax.swing.JFormattedTextField;

public class Ex06 {

	private JFrame frame;
	private JTextField textField;
	private JTable table;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Ex06 window = new Ex06();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Ex06() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 450, 300);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		textField = new JTextField();
		textField.setBounds(24, 34, 116, 21);
		frame.getContentPane().add(textField);
		textField.setColumns(10);
		
		JButton btnNewButton = new JButton("New button");
		btnNewButton.setBounds(152, 33, 97, 23);
		frame.getContentPane().add(btnNewButton);
		
		JSplitPane splitPane = new JSplitPane();
		splitPane.setBounds(186, 236, 189, 26);
		frame.getContentPane().add(splitPane);
		
		table = new JTable();
		table.setBounds(17, 82, 138, 118);
		frame.getContentPane().add(table);
		
		JFormattedTextField formattedTextField = new JFormattedTextField();
		formattedTextField.setBounds(217, 65, 46, 120);
		frame.getContentPane().add(formattedTextField);
	}
}
