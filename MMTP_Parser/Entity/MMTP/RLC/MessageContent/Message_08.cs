﻿using MMTP_Parser.Entity.Custom;
using System.Collections.ObjectModel;
namespace MMTP_Parser.Entity.MMTP.RLC.MessageContent
{
    /// <summary>
    ///Processing rules
    /// The Start of Session message indicates the start of a system at the beginning of a new trading session. More precisely, this message announces, at the beginning of each new trading day, that the system is starting its activity of sending MMTP messages.
    /// As a general rule, each system that sends MMTP messages sends 0 or 1 start of session message per trading day. However:
    ///     * NSC® sends one start of session message per trading unit.
    ///     * The sending of such a message is optional (some system do not send it).
    ///NSC® Transmission functions
    /// Management of start of session for trading day
    ///     The start of session management process sends a starting message to the broadcasting process. It then sends all messages generated by "Post-Session" processing during post session.
    /// Changeover the group of instrument's status
    ///     The session management process sends an End of Session message as soon as all the non- forbidden groups of instruments have switched to post-session state (End-of-Day Inquiries).
    ///PFI2 Transmission Functions
    /// The PFI2 application sends 1 type-07 message per trading day. This message is sent by the start-of-day batch processes, which are started at a specific configurable time (currently, 6:15 am ET). This message precedes all other MMTP messages sent by PFI2. the PFI2 application sends 1 type-08 message per trading day. This message is sent by the end-of-day batch processes, which are started when all the following conditions are met:
    ///     1. The earliest time for starting end-of-day batch processes has been reached (a configurable time).
    ///     2. The Cash Instruments Reference Data coming from RCE has been processed.
    ///     3. All indices are closed (and therefore all type-B2 messages have been sent).
    /// </summary>
    public class Message_08 : MessageContents //Length ==>0 , Short description ==> End of Session
    {
        public Message_08()
        {
            _ObsFields = new ObservableCollection<Field>();
        }
    }
}
