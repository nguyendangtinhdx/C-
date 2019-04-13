
// VeDuongThangDlg.h : header file
//

#pragma once


// CVeDuongThangDlg dialog
class CVeDuongThangDlg : public CDialogEx
{
// Construction
public:
	CVeDuongThangDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	enum { IDD = IDD_VEDUONGTHANG_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support


// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	int xa;
	int ya;
	int xb;
	int yb;
	void BresLine(int xa, int ya, int xb, int yb);
	afx_msg void OnBnClickedOk();
	afx_msg void OnEnChangeEdit4();
};
