<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfrStudent.aspx.cs" Inherits="Lab10_Ex1_DatagridView_Student.wfrStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <script src="bootstrap/js/bootstrap.bundle.min.js"></script>
    <style type="text/css">
        .table-striped {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="formStudent" runat="server">
        <div class="container">
            <div class="row">
                <div class="col">

                    <div class="row">
                        <div class="col">
                            <h3>Danh sách sinh viên</h3>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col">
                            <asp:GridView CssClass="table table-striped" ID="gvStudent" runat="server" 

                                OnRowCommand="gvStudent_RowCommand" OnRowEditing="gvStudent_RowEditing" OnRowCancelingEdit="gvStudent_RowCancelingEdit"
                                OnRowUpdating="gvStudent_RowUpdating" OnRowDeleting="gvStudent_RowDeleting"

                                PageSize="10" OnPageIndexChanging="gvStudent_PageIndexChanging" AllowPaging="true" 
                                AutoGenerateColumns="false" ShowFooter="true" ShowHeaderWhenEmpty="true" 
                                DataKeyNames="MSSV" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" 
                                BorderWidth="1px" CellPadding="3">
                                <Columns>
                                    <asp:TemplateField  ItemStyle-Width="150px" HeaderText="">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="btnEdit" CommandName="Edit" ToolTip="Edit" runat="server">Edit</asp:LinkButton>
                                            <asp:LinkButton ID="btnDelete" CommandName="Delete" ToolTip="Delete" runat="server">Delete</asp:LinkButton>
                                            <asp:LinkButton ID="btnSelect" CommandName="Select" ToolTip="Select" runat="server">Select</asp:LinkButton>
                                        </ItemTemplate>

                                        <EditItemTemplate>
                                            <asp:LinkButton ID="btnUpdate" CommandName="Update" ToolTip="Update" runat="server">Update</asp:LinkButton>
                                            <asp:LinkButton ID="Cancel" CommandName="Cancel" ToolTip="Cancel" runat="server">Cancel</asp:LinkButton>
                                            <asp:LinkButton ID="btnSelect" CommandName="Select" ToolTip="Select" runat="server">Select</asp:LinkButton>
                                        </EditItemTemplate>

                                        <FooterTemplate>
                                            <asp:LinkButton ID="btnAdd" CommandName="AddNew" ToolTip="Add new" runat="server">Add new</asp:LinkButton>
                                        </FooterTemplate>

                                        <ItemStyle Width="50px"></ItemStyle>
                                    </asp:TemplateField>

                                    <asp:TemplateField ItemStyle-Width="100px" HeaderText="Mã sinh viên">
                                        <ItemTemplate>
                                            <asp:Label ID="lblMSSV" runat="server" Text='<%# Eval("MSSV") %>'></asp:Label>
                                        </ItemTemplate>

                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtMSSV" runat="server" Text='<%# Eval("MSSV") %>' ReadOnly="true"></asp:TextBox>
                                        </EditItemTemplate>

                                        <FooterTemplate>
                                            <asp:TextBox ID="txtMSSVFooter" runat="server"></asp:TextBox>
                                        </FooterTemplate>

                                        <ItemStyle Width="100px"></ItemStyle>
                                    </asp:TemplateField>

                                    <asp:TemplateField ItemStyle-Width="100px" HeaderText="Họ tên">
                                        <ItemTemplate>
                                            <asp:Label ID="lblHoTen" runat="server" Text='<%# Eval("HoTen") %>'></asp:Label>
                                        </ItemTemplate>

                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtHoTen" runat="server" Text='<%# Eval("HoTen") %>'></asp:TextBox>
                                        </EditItemTemplate>

                                        <FooterTemplate>
                                            <asp:TextBox ID="txtHoTenFooter" runat="server"></asp:TextBox>
                                        </FooterTemplate>

                                        <ItemStyle Width="100px"></ItemStyle>
                                    </asp:TemplateField>

                                    <asp:TemplateField ItemStyle-Width="100px" HeaderText="Phái">
                                        <ItemTemplate>
                                            <asp:Label ID="lblGioiTinh" runat="server" Text='<%# Eval("GioiTinh") %>' style="text-align: center"></asp:Label>
                                            <br />
                                        </ItemTemplate>

                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtGioiTinh" runat="server" Text='<%# Eval("GioiTinh") %>'></asp:TextBox>
                                        </EditItemTemplate>

                                        <FooterTemplate>
                                            <asp:TextBox ID="txtGioiTinhFooter" runat="server"></asp:TextBox>
                                        </FooterTemplate>

                                        <ItemStyle Width="100px"></ItemStyle>
                                    </asp:TemplateField>

                                    <asp:TemplateField ItemStyle-Width="100px" HeaderText="Lớp">
                                        <ItemTemplate>
                                            <asp:Label ID="lblMaLop" runat="server" Text='<%# Eval("MaLop") %>'></asp:Label>
                                        </ItemTemplate>

                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtMaLop" runat="server" Text='<%# Eval("MaLop") %>'></asp:TextBox>
                                        </EditItemTemplate>

                                        <FooterTemplate>
                                            <asp:TextBox ID="txtMaLopFooter" runat="server"></asp:TextBox>
                                        </FooterTemplate>

                                        <ItemStyle Width="100px"></ItemStyle>
                                    </asp:TemplateField>
                                </Columns>

                                <FooterStyle BackColor="White" ForeColor="#000066" />
                                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                <RowStyle ForeColor="#000066" />
                                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#00547E" />
                            </asp:GridView>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col">
                            <br />
                        </div>
                    </div>

                    <div class="row">
                        <div class="col">
                            <asp:Label CssClass="text-success" ID="lblSuccessMessage" runat="server" Text=""></asp:Label>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col">
                            <br />
                        </div>
                    </div>

                    <div class="row">
                        <div class="col">
                            <asp:Label CssClass="text-bg-warning" ID="lblErrorMessage" runat="server" Text=""></asp:Label>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </form>

    <script src="bootstrap/js/bootstrap.bundle.min.js"></script>
</body>
</html>
