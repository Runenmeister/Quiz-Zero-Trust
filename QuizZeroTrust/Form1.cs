using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace QuizZeroTrust
{
    public partial class Form1 : Form
    {
        // variables list for this quiz game
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 42;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage here
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);
                MessageBox.Show
                    ("Quiz Ended" + Environment.NewLine +
                                "You have answered " + score + " questions correcly" + Environment.NewLine +
                                "Your total percentage is " + percentage + " %" + Environment.NewLine + Environment.NewLine +
                                "Click Ok to play again"

                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }

            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "What is Zero Trust?";

                    Btn1.Text = "A security model that trusts everything by default.";
                    Btn2.Text = "A security model that trusts nothing by default.";
                    Btn3.Text = "A security model that only trusts external threats.";
                    Btn4.Text = "A security model that only trusts internal users.";

                    correctAnswer = 2;
                    break;
                case 2:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "What is a basic assumption of Zero Trust?";

                    Btn1.Text = "The network is assumed to be friendly.";
                    Btn2.Text = "External and internal threats are not present.";
                    Btn3.Text = "Network locality is sufficient for determining trust.";
                    Btn4.Text = "The network is assumed to be hostile.";

                    correctAnswer = 4;
                    break;
                case 3:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "What does Zero Trust commit to removing within the IT ecosystem?";

                    Btn1.Text = "External threats.";
                    Btn2.Text = "Internal threats.";
                    Btn3.Text = "Implicit trust.";
                    Btn4.Text = "Explicit trust.";

                    correctAnswer = 3;
                    break;
                case 4:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "What does the Devices Pillar do in Zero Trust?";

                    Btn1.Text = "Focuses on user identification and access control policies.";
                    Btn2.Text = "Determines acceptable cybersecurity posture and thrustworthiness of devices.";
                    Btn3.Text = "Analyzes data to provide visibility into network traffic.";
                    Btn4.Text = "Automates security processes to reduce human error.";

                    correctAnswer = 2;
                    break;
                case 5:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "Who coined the term Zero Trust?";

                    Btn1.Text = "Google.";
                    Btn2.Text = "NIST.";
                    Btn3.Text = "John Kindervag.";
                    Btn4.Text = "Jericho Forum.";

                    correctAnswer = 3;
                    break;
                case 6:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "What is the purpose of segmenting a trusted network in ZTA?";

                    Btn1.Text = "To make it easier for users  to access ressources.";
                    Btn2.Text = "To protect individual business assets and ressources.";
                    Btn3.Text = "To increase the blast radius by allowing lateral movement.";
                    Btn4.Text = "None of these.";

                    correctAnswer = 2;
                    break;
                case 7:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "What is one of the main challenges of perimeter security in modern IT infrastructures?";

                    Btn1.Text = "The increased complexity of IT environments.";
                    Btn2.Text = "The lack of trust between employees and employers.";
                    Btn3.Text = "The high cost of implementing security measures.";
                    Btn4.Text = "The lack of available security solutions.";

                    correctAnswer = 1;
                    break;
                case 8:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "How has COVID-19 impacted digital transformation?";

                    Btn1.Text = "It has slowed down digital transformation efforts.";
                    Btn2.Text = "It has accelerated digital transformation by six years.";
                    Btn3.Text = "It has had no impact on digital transformation.";
                    Btn4.Text = "It has made digital transformation irrelevant.";

                    correctAnswer = 2;
                    break;
                case 9:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "What is the top concern that companies have regarding the implementation of zero trust security?";

                    Btn1.Text = "BYOD.";
                    Btn2.Text = "Shadow IT.";
                    Btn3.Text = "Skills Gap.";
                    Btn4.Text = "Cost Concerns.";

                    correctAnswer = 4;
                    break;
                case 10:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "What is the top benefit that companies have reported after implementing a zero trust security initiative?";

                    Btn1.Text = "Improved Risk Management.";
                    Btn2.Text = "Improved Secure Remote Access.";
                    Btn3.Text = "Reduced Number of IT Security Incidents.";
                    Btn4.Text = "Lower Overall Security Costs.";

                    correctAnswer = 1;
                    break;
                case 11:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "The ________________ enables, monitors, and terminates connections between a subject and an enterprise resource.";

                    Btn1.Text = "Policy Enforcement Point.";
                    Btn2.Text = "Policy Administrator.";
                    Btn3.Text = "Policy Engine.";
                    Btn4.Text = "Policy Decision Point.";

                    correctAnswer = 1;
                    break;
                case 12:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "What is the difference between the Implicit Trust Zone and the Untrusted Zone in the Zero Trust model?";

                    Btn1.Text = "The Implicit Trust Zone contains untrusted resources, while the Untrusted Zone contains trusted resources.";
                    Btn2.Text = "The Implicit Trus Zone contains trusted resources, while the Untrusted Zone contains untrusted users.";
                    Btn3.Text = "There is no difference between these two Zones.";
                    Btn4.Text = "None of these.";

                    correctAnswer = 2;
                    break;
                case 13:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "Which deployment model uses a Gateway Web Portal to access protected resources?";

                    Btn1.Text = "Device Agent/Gateway Deployment Model.";
                    Btn2.Text = "Resource  Portal Deployment Model.";
                    Btn3.Text = "Enclave-Based Deployment Model.";
                    Btn4.Text = "None of these.";

                    correctAnswer = 2;
                    break;
                case 14:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "________________ are database feeds that provide information regarding newly discovered attacks and vulnerabilities.";

                    Btn1.Text = "Activity Logs.";
                    Btn2.Text = "Data Access Policies.";
                    Btn3.Text = "SIEM System.";
                    Btn4.Text = "Threat Intelligence.";

                    correctAnswer = 4;
                    break;
                case 15:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "Zero Trust uses a combination of role-based and attribute-based access control.";

                    Btn1.Text = "True.";
                    Btn2.Text = "False.";


                    correctAnswer = 1;
                    break;
                case 16:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "When referring to geolocation, what aspect of the Kipling method are we referring to?";

                    Btn1.Text = "Who.";
                    Btn2.Text = "What.";
                    Btn3.Text = "When.";
                    Btn4.Text = "Where.";
                    Btn5.Text = "Why.";
                    Btn6.Text = "How.";

                    correctAnswer = 4;
                    break;
                case 17:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "Which of the following is NOT one of the Zero Trust Architectural Pillars?";

                    Btn1.Text = "Users and Identity.";
                    Btn2.Text = "Devices.";
                    Btn3.Text = "Cloud Computing.";
                    Btn4.Text = "Network and Environment.";

                    correctAnswer = 3;
                    break;
                case 18:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "Multi-factor authentication is a means of protecting which pillar?";

                    Btn1.Text = "Users and Identity Pillar.";
                    Btn2.Text = "Devices Pillar.";
                    Btn3.Text = "Network and Environment Pillar.";
                    Btn4.Text = "Applications and Workload Pillar.";
                    Btn5.Text = "Data Pillar.";

                    correctAnswer = 1;
                    break;
                case 19:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "Understanding how data flows throughout the network is essential to protecting the Network and Environment Pillar.";

                    Btn1.Text = "True.";
                    Btn2.Text = "False.";

                    correctAnswer = 1;
                    break;
                case 20:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "________________ is used to detect and prevent the leakage or misuse of sensitive data.";

                    Btn1.Text = "Privileged Access Management (PAM).";
                    Btn2.Text = "Endpoint Detection and Response (EDR).";
                    Btn3.Text = "Threat Intelligence.";
                    Btn4.Text = "Data Loss Protection (DLP).";

                    correctAnswer = 4;
                    break;
                case 21:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "Which aspect of the ZTA helps to reduce alarm fatigue?";

                    Btn1.Text = "Applications and Workload Pollar.";
                    Btn2.Text = "Automation and Orchestration.";
                    Btn3.Text = "User and Identity Pillar.";
                    Btn4.Text = "Visibility and Analytics.";

                    correctAnswer = 2;
                    break;
                case 22:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "Which of the following is NOT a design principle for Zero Trust?";

                    Btn1.Text = "Focus on Business Outcomes.";
                    Btn2.Text = "Design from the Outsind In.";
                    Btn3.Text = "Determine Who and What needs Access.";
                    Btn4.Text = "Inspect and Log All Traffic.";

                    correctAnswer = 2;
                    break;
                case 23:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "There is a singular correct way to design a ZTA, and you shouldn't deviate from it.";

                    Btn1.Text = "True.";
                    Btn2.Text = "False.";

                    correctAnswer = 2;
                    break;
                case 24:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "Another terminology for your protect surfaces is ____________.";

                    Btn1.Text = "DLP.";
                    Btn2.Text = "JIT.";
                    Btn3.Text = "DAAS.";
                    Btn4.Text = "PDP.";

                    correctAnswer = 3;
                    break;
                case 25:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "According to Forrester, you should create your ZTA policies ____________ you design your ZTA.";

                    Btn1.Text = "Before.";
                    Btn2.Text = "After.";

                    correctAnswer = 2;
                    break;
                case 26:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "Scanning for malicious and unauthorized activities is a part of what design principle?";

                    Btn1.Text = "Determine Who and What needs Access.";
                    Btn2.Text = "Inspect and Log All Traffic.";
                    Btn3.Text = "Map Transaction Flows.";
                    Btn4.Text = "Identy Your Sensitive Data.";

                    correctAnswer = 2;
                    break;
                case 27:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "This helps you to fine-tune and improve your ZTA over time.";

                    Btn1.Text = "Defining Your Protected Surfaces.";
                    Btn2.Text = "Creating Your ZTA Policies.";
                    Btn3.Text = "Monitoring and Maintaining Your ZTA.";
                    Btn4.Text = "Mapping Your Transaction Flows.";

                    correctAnswer = 3;
                    break;
                case 28:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "Zero Trust's main hurdle is technological, not cultural.";

                    Btn1.Text = "True.";
                    Btn2.Text = "False.";

                    correctAnswer = 2;
                    break;
                case 29:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "What is one business benefit of Zero Trust?";

                    Btn1.Text = "Increase Data breach risk.";
                    Btn2.Text = "Reduced brand reputation and public trust.";
                    Btn3.Text = "Cost savings through simplified security.";
                    Btn4.Text = "Higher IT complexity.";

                    correctAnswer = 3;
                    break;
                case 30:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "When communicating Zero Trust to key stakeholders and decisions makers, we should translate ____________ speak into ____________ speak.";

                    Btn1.Text = "Business; IT.";
                    Btn2.Text = "IT; Business.";

                    correctAnswer = 2;
                    break;
                case 31:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "Why is it important to review progress and analyze results in the change management process?";

                    Btn1.Text = "To skip testing in a development environment to save time.";
                    Btn2.Text = "To implement changes all at once across the entire organization.";
                    Btn3.Text = "To understand what worked well an what needs improvment for the future changes.";
                    Btn4.Text = "To rely on industry best practices for change management.";

                    correctAnswer = 3;
                    break;
                case 32:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "When building a Zero Trust team, it's important to ONLY include IT unit stakeholders and subject matter experts.";

                    Btn1.Text = "True.";
                    Btn2.Text = "False.";

                    correctAnswer = 2;
                    break;
                case 33:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "According to the Zero Trust Implementation Curve, we should start with our ____________ protect surfaces.";

                    Btn1.Text = "Crown Jewles.";
                    Btn2.Text = "Learning.";
                    Btn3.Text = "Practice.";
                    Btn4.Text = "Secondary.";

                    correctAnswer = 2;
                    break;
                case 34:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "Utilizing a ZTA with a PDP/PEP and gateway eliminates the need for a VPN.";

                    Btn1.Text = "True.";
                    Btn2.Text = "False.";

                    correctAnswer = 1;
                    break;
                case 35:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "_____________ limit the blast radius of an attack.";

                    Btn1.Text = "Policy Enforcement Point.";
                    Btn2.Text = "Identity Governance.";
                    Btn3.Text = "Micro Perimeters.";

                    correctAnswer = 3;
                    break;
                case 36:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "________________ forms context-aware virtual networks for our assets at the network layer.";

                    Btn1.Text = "Identity Government.";
                    Btn2.Text = "Application Micro-Segmentation.";
                    Btn3.Text = "Software-Defined Networking.";

                    correctAnswer = 3;
                    break;
                case 37:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "With a ____________ design, authentication and authorization are granted based on location, role, username/password, PKI, and two-factor authentication.";

                    Btn1.Text = "Conventional.";
                    Btn2.Text = "Zero Trust.";

                    correctAnswer = 1;
                    break;
                case 38:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "Zero Trust utilizes a much more robust dynamic and contextual process than a conventual security model.";

                    Btn1.Text = "True.";
                    Btn2.Text = "False.";

                    correctAnswer = 1;
                    break;
                case 39:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "The first phase of the NSA's Zero Trust Maturity Model involves the following activities:";

                    Btn1.Text = "Implement Fundamental integrated capabilities.";
                    Btn2.Text = "Refine capabilities integration and further refine capabilities.";
                    Btn3.Text = "Initial discovery and assessment activities.";

                    correctAnswer = 3;
                    break;
                case 40:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "What is the highest level of maturity in the Microsoft Zero Trust Maturity Model?";

                    Btn1.Text = "Traditional.";
                    Btn2.Text = "Advanced.";
                    Btn3.Text = "Optimal.";

                    correctAnswer = 3;
                    break;
                case 41:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "When an organization begins using machine learning and AI, Microsoft, and CISA would deem them to be at the ____________ stage.";

                    Btn1.Text = "Traditional.";
                    Btn2.Text = "Advanced.";
                    Btn3.Text = "Optimal.";

                    correctAnswer = 3;
                    break;
                case 42:
                    Pb1.Image = Properties.Resources.logo;
                    LblQuestion.Text = "You are maturing your ZTA, and you've gone from utilizing large network macro-segments to micro-perimeters. According to CISA, your Network/Environment Pillar would be at the ____________ stage.";

                    Btn1.Text = "Traditional.";
                    Btn2.Text = "Advanced.";
                    Btn3.Text = "Optimal.";

                    correctAnswer = 2;
                    break;
            }
        }




        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnKontakt_Click(object sender, EventArgs e)
        {
            string toAddress = "itsupport@mdagehrmann.de";
            string subject = "Kontaktaufnahme: Quiz Zero Trust";
            string body = "Sehr geehrter Herr Gehrmann,%0D%0A " +
                "ich komme heute auf Sie zu mit einer bestimmten Anfrage. " +
                "%0D%0A" +
                "%0D%0A" +
                "%0D%0A" +
                "Mit freundlichen Grüßen";

            MailMessage mail = new MailMessage();
            mail.To.Add(toAddress);
            mail.Subject = subject;
            mail.Body = body;

            try
            {
                System.Diagnostics.Process.Start("mailto:" + toAddress + "?subject="
                + subject + "&body=" + body);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Öffnen der E-Mail: " + ex.Message);
            }
        }
    }
}
