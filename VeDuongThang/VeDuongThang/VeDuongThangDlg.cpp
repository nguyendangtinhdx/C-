
// VeDuongThangDlg.cpp : implementation file
//

#include "stdafx.h"
#include "VeDuongThang.h"
#include "VeDuongThangDlg.h"
#include "afxdialogex.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CAboutDlg dialog used for App About

class CAboutDlg : public CDialogEx
{
public:
	CAboutDlg();

// Dialog Data
	enum { IDD = IDD_ABOUTBOX };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

// Implementation
protected:
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialogEx(CAboutDlg::IDD)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialogEx)
END_MESSAGE_MAP()


// CVeDuongThangDlg dialog



CVeDuongThangDlg::CVeDuongThangDlg(CWnd* pParent /*=NULL*/)
	: CDialogEx(CVeDuongThangDlg::IDD, pParent)
	, xa(0)
	, ya(0)
	, xb(0)
	, yb(0)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CVeDuongThangDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Text(pDX, IDC_EDIT1, xa);
	DDX_Text(pDX, IDC_EDIT2, ya);
	DDX_Text(pDX, IDC_EDIT3, xb);
	DDX_Text(pDX, IDC_EDIT4, yb);
}

BEGIN_MESSAGE_MAP(CVeDuongThangDlg, CDialogEx)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDOK, &CVeDuongThangDlg::OnBnClickedOk)
	ON_EN_CHANGE(IDC_EDIT1, &CVeDuongThangDlg::OnEnChangeEdit1)
	ON_EN_CHANGE(IDC_EDIT4, &CVeDuongThangDlg::OnEnChangeEdit4)
END_MESSAGE_MAP()


// CVeDuongThangDlg message handlers

BOOL CVeDuongThangDlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// Add "About..." menu item to system menu.

	// IDM_ABOUTBOX must be in the system command range.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		BOOL bNameValid;
		CString strAboutMenu;
		bNameValid = strAboutMenu.LoadString(IDS_ABOUTBOX);
		ASSERT(bNameValid);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon

	// TODO: Add extra initialization here

	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CVeDuongThangDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialogEx::OnSysCommand(nID, lParam);
	}
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CVeDuongThangDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialogEx::OnPaint();
	}
}

// The system calls this function to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CVeDuongThangDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}



void CVeDuongThangDlg::BresLine(int xa, int ya, int xb, int yb)
{

	CDC *p_DC = this->GetDC();  COLORREF Color = RGB(255, 0, 0); //Màu đỏ 

	int Dx = xb - xa, Dy = yb - ya;  int P = 2 * Dy - Dx, Const1 = 2 * Dy, Const2 = 2 * Dy - 2 * Dx;  int x = xa, y = ya;

	p_DC->SetPixel(x, y, Color);

	while (x < xb)   
	{   x++;   if (P < 0)   
	{    P += Const1;   }  
	else   
	{    y++;    P += Const2;   }  
	p_DC->SetPixel(x, y, Color);  
	} 
}


void CVeDuongThangDlg::OnBnClickedOk()
{
	UpdateData(true);  // Gọi hàm vẽ đoạn thẳng theo giải thuật Bresenham đã cài đặt  
	BresLine(xa, ya, xb, yb);
}





