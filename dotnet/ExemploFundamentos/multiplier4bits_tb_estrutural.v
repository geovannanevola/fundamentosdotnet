`timescale 1ns/10ps

module multiplier_tb;
    reg [3:0] a, b;
    wire [7:0] m_result;
    
	//Instanciando o módulo do multiplicado
    multiplier mult4(m_result, a, b);
    
    initial begin
	//Entrada de dados de forma vetorial
	a = 4'b1111;	b = 4'b1111;	#2  //15 * 15
    a = 4'b1010;	b = 4'b0000;	#2  //10 * 0
	a = 4'b1010;	b = 4'b1010;	#2  //10 * 10
	a = 4'b0001;	b = 4'b1001;	#2  //1 * 9
	a = 4'b0010;	b = 4'b0111;	    //2 * 7
    end
endmodule