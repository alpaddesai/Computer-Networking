using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ComputerNetworking
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Protocols_Click(object sender, RoutedEventArgs e)
        {
            Protocols ProtocolsObject = new Protocols();
            ProtocolsObject.Show();
        }

        private void I2C_Bus_Click(object sender, RoutedEventArgs e)
        {
            I2Cbus I2Cbusobject = new I2Cbus();
            I2Cbusobject.Show();
        }

        private void RS_232_Click(object sender, RoutedEventArgs e)
        {
        
            MessageBox.Show(" Also known as the serial port or serial communications interface (SCI), commonly replaced by the USB in PC, standard data rate of 20kb/s, direction point to point connection with single ended pins with a data carrier detect, received data, transmitted data, data terminal ready, data set ready, request to send clear to send and signal ground", "RS232");

        }

      
        private void IO_link_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Power Management Bus, utilized for the protection of power generation and management ICs, derivative and compliant with I2C bus specifications, it just includes an interrupt SMBALERT and on-off control lines, data rate 100 to 400 kb/s with logic levels of 0.8 to 2.1v and includes a dedicated adaptive voltage scaling (AVS) bus to control processor voltages", "PMBUS");
            MessageBox.Show("System Management Bus, applications include control of power monitor and control ICs, temperature monitors and battery chargers, data rate is 10 to 100kb/s with logic levels of 0.8 to 2.1 v, it's the same as I2C plus an interrupt line, it includes a one byte CRC -8 checksum at the end of the each transmission and adds a SMBALERT # interrupt line to the bus for interrupt handling", "System Management Bus");
        }


        private void JTAG_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Joint test action group serial communication interface is utilized to test pcb and large IC in a production environment.  Utilizes a boundary scan technique to test IC pin connections with a data rate in the 10 to 50Mb/s range. The interface is called the serial test access port (TAP), digital functionality includes the TCK, TDI, TDO, TMS and TRST logic pins   ","JTAG");
        }

        private void Ethernet_Click(object sender, RoutedEventArgs e)
        {
            Ethernet EthernetObject = new Ethernet();
            EthernetObject.Show();
        }

        private void SPI_Click(object sender, RoutedEventArgs e)
        {
            Serial_Peripheral_Interface__SPI_ Serial_Peripheral_Interface__SPI_Object = new Serial_Peripheral_Interface__SPI_();
            Serial_Peripheral_Interface__SPI_Object.Show();
        }

        private void USB_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show(" All purpoose serial interface for the PC for various peripheral, consumer electronics including cameras and flash storage devices (USB Drives), the data rates are 12Mbps, 480Mbps and 10Gbps", "USB");
        }

        private void GE_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("LANs, MAN, WAN, industrial networks, backplanes and data center connectivity, key features include multiple speed levels 10 to 100Gb/s, twisted pair or fibter optical medium, full duplex operation   ","Gigabit Ethernet");

        }

        private void PCIe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" The interface between the processor and the most peripheral chips and devices in modern computers, laptops and servers, key features include serial data paths that boost data speeds between processor and peripherals, data transfer via full duplex using two diff pairs; Lane speeds are version dependent. version 1: 2.5Gbps , version 2: 5 Gbps, version 3: 6 Gbps (128B/130B) version 4: 16 Gbps, its; a three layer OSI like protocol using the physical layer, data link layer and a transaction layer ", "PCIe");
        }

        private void Fibre_Channel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show( "High data rates 16Gb/s with 8b/10b or 64b/66b encoding , is is  layered protocol which does not follow the OSI model, utilized primarily in storage area networks (SANs) and connection of peripheral devices to main frames and super computers " , "Fibre Channel");
        }

        private void RapidIO_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Utilized in high performance computing (HPC) , data center servers, network storage, cellular communications infrastructure, industrial controls, aerospace and military, the key features include chip to chipconnections, DSPs, peripheral devices or memory I/O, PCB to PCB connections via a backplane, high speed multiple parallel serial links, low latency, its a replacement link for Ethernet and PCIe, the network configuration is full duplex, ethernet 8b/10b coding, 64b/67b coding. It uses layers similar to the OSI model with a logical , transport and physical layer.", "RapidIO");
        }

        private void LVDS_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" A physical layer only serial technology, with high speed 1 to 3Gb/s and low power consumption, it supports half duplex operation with differential LVDS levels 1 to 1.4+-350mV with 100 ohm termination impedance. ","LVDS");
        }

        private void Bluetooth_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Applications include wireless headsets, speaks, PANs, IoT, game controllers, the frequency of operation is 2.4 to 2.48Ghz, the protocol is packet pased, with Forward error correction, 24 bit CRC, encryption and adaptive hoping for interference mitigation  ","Bluetooth");
        }

        private void WiFi_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" It's a radio data link, the wireless local area network (WLAN) standard utilized to provide wireless internet, it operates at 2.4Ghz with mutiple channel spaced 5Mhz apart providing a 54Mbits/s maximum bandwidth using frequency division multiplexing (FDM). WIFI implementation is governed by IEEE 802.11 standard", "WiFi");
        }

        private void ZigBee_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Applications include IoT, smart grid metering, lighting control, wireless remote control, WPAN, the international standard is IEEE 802.15.4a/b, key features include  short range, low speed, data rates includes 20kb/s (868Mhz band), 40kb/s (902-928Mhz band), 250kb/s (2.4Ghz band) and utilizes a modulation method of direct sequence spread spectrum. The ZigBee protocol stack i on the OSI layer", "ZigBee");
        }

        private void Internet_Protocol_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Internet protocol is the dominant protocol at the internet layer. This layer is primarily responsible for routing packets from one host to another, each packet contains the address information needed for its routing through the internet to the receiving host","Internet Protocol");
            MessageBox.Show(" The host to host layer is responsible for data integrity between the sender host and the receiver host, communications errors are corrected and detected at this level, Two protocols are active in this layer the User Data protocol (UDP) It is a connectionless protocol used for higher layer port address, and the Transmission control protocol (TCP) which is a connection-oriented protocol that offers improved protection and error control");
            MessageBox.Show(" The process and applications layer provides programs with interfaces to the TCP/IP stack, common protocols at this layer include  FTP (file transfer protocol, it transfers files between hosts using TCP, the SMTP ( simple mail transfer protocol) it provides access to the TCP and IP programs for sending email and TELNET (telecommunications network: used to emulate terminals for remote access to servers");
        }

        private void Broadband_Interface_Concepts_Click(object sender, RoutedEventArgs e) // UART button
        {
            MessageBox.Show(" It implements an asynchronouse data transceiver. For asynchronous transmission the UART handles the details of sending the start, data and stop bits. When receiving the information, it shifts in any serial data it receives and then sets a status flag indicating that data is ready. The low speed more uses a 16x clock for sampling each bit , the high speed mode only uses a 4x clock for sampling each bit, this defined by the Baud rate", "Universal Asynchronous Receiver Transmitter (UART)");

        }
    }
}
