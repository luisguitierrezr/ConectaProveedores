using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] Proposal (WzhkHt4fcEmbR6Ng+t0_1A)
///  <code>EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord</code> that represents <code>Proposal</code
/// > <p>Description: Entity that holds Proposals info.</p>
/// </summary>
// Name: Proposal
public partial struct EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord : ITypedRecord<EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*qsFieeSkoUqGMBsWi5_QiQ");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0MtXrpEGZk+91G+A08zOyw");
internal static readonly GlobalObjectKey IdPaymentDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*jyAMLuqWpEeHM9UxEU+xiw");
internal static readonly GlobalObjectKey IdProposalDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*3Twhtt73kUChhPYocrm9WA");
internal static readonly GlobalObjectKey IdProposalTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*DEpOx_p_X0iLUzObkIs5lA");
internal static readonly GlobalObjectKey IdBankId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*nJebnbrPDU2mDA8WecnNeg");
internal static readonly GlobalObjectKey IdProposalStatusId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*yUqZj2FhgEmZBAXcE9ZO6Q");
internal static readonly GlobalObjectKey IdFileId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*xYGr7D4NWEWhD_DBM8mAlA");
internal static readonly GlobalObjectKey IdTotalProposalLines = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*zcCWBSa10Ui8gQopOdtvBg");
internal static readonly GlobalObjectKey IdTotalValueML = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vuGAz4lA8UaR5PG0cv5Rbw");
internal static readonly GlobalObjectKey IdTotalValueMD = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*y7F8v20R6keUUgagi41PZQ");
internal static readonly GlobalObjectKey IdCurrencyId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Sq0SJik1YkCpqWoCTiFDrQ");
internal static readonly GlobalObjectKey IdRegionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*+FIgwHUw802DEF9OiBX2Tw");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*oGI0vF2m10aN6joT02nlbg");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*6RKHaOcb1Uu1KdY0RfCGEA");
internal static readonly GlobalObjectKey IdLastUpdatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ZRLvcaozi022qjkYcELW6w");
internal static readonly GlobalObjectKey IdMaxDatePaymentChanges = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*MyF2TEYceEqNiuXNoO0EEg");
internal static readonly GlobalObjectKey IdAssignedToId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*OHI3IIMRmkuyP3aea8Lr8g");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(18,true);
          _ssId = value;
      }
  }
}

private string _ssName;
public string ssName{
  get{
      return _ssName;
  }
  set{
      if((_ssName!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssName = value;
      }
  }
}

private DateTime _ssPaymentDate;
public DateTime ssPaymentDate{
  get{
      return _ssPaymentDate;
  }
  set{
      if((_ssPaymentDate!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssPaymentDate = value;
      }
  }
}

private DateTime _ssProposalDate;
public DateTime ssProposalDate{
  get{
      return _ssProposalDate;
  }
  set{
      if((_ssProposalDate!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssProposalDate = value;
      }
  }
}

private int _ssProposalTypeId;
public int ssProposalTypeId{
  get{
      return _ssProposalTypeId;
  }
  set{
      if((_ssProposalTypeId!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssProposalTypeId = value;
      }
  }
}

private long _ssBankId;
public long ssBankId{
  get{
      return _ssBankId;
  }
  set{
      if((_ssBankId!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssBankId = value;
      }
  }
}

private int _ssProposalStatusId;
public int ssProposalStatusId{
  get{
      return _ssProposalStatusId;
  }
  set{
      if((_ssProposalStatusId!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssProposalStatusId = value;
      }
  }
}

private long _ssFileId;
public long ssFileId{
  get{
      return _ssFileId;
  }
  set{
      if((_ssFileId!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssFileId = value;
      }
  }
}

private int _ssTotalProposalLines;
public int ssTotalProposalLines{
  get{
      return _ssTotalProposalLines;
  }
  set{
      if((_ssTotalProposalLines!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssTotalProposalLines = value;
      }
  }
}

private decimal _ssTotalValueML;
public decimal ssTotalValueML{
  get{
      return _ssTotalValueML;
  }
  set{
      if((_ssTotalValueML!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssTotalValueML = value;
      }
  }
}

private decimal _ssTotalValueMD;
public decimal ssTotalValueMD{
  get{
      return _ssTotalValueMD;
  }
  set{
      if((_ssTotalValueMD!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssTotalValueMD = value;
      }
  }
}

private string _ssCurrencyId;
public string ssCurrencyId{
  get{
      return _ssCurrencyId;
  }
  set{
      if((_ssCurrencyId!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssCurrencyId = value;
      }
  }
}

private long _ssRegionId;
public long ssRegionId{
  get{
      return _ssRegionId;
  }
  set{
      if((_ssRegionId!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssRegionId = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssCreatedBy = value;
      }
  }
}

private DateTime _ssCreatedOn;
public DateTime ssCreatedOn{
  get{
      return _ssCreatedOn;
  }
  set{
      if((_ssCreatedOn!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
          _ssCreatedOn = value;
      }
  }
}

private DateTime _ssLastUpdatedOn;
public DateTime ssLastUpdatedOn{
  get{
      return _ssLastUpdatedOn;
  }
  set{
      if((_ssLastUpdatedOn!=value) || OptimizedAttributes[15]){
          ChangedAttributes[15] = true;
          _ssLastUpdatedOn = value;
      }
  }
}

private DateTime _ssMaxDatePaymentChanges;
public DateTime ssMaxDatePaymentChanges{
  get{
      return _ssMaxDatePaymentChanges;
  }
  set{
      if((_ssMaxDatePaymentChanges!=value) || OptimizedAttributes[16]){
          ChangedAttributes[16] = true;
          _ssMaxDatePaymentChanges = value;
      }
  }
}

private string _ssAssignedToId;
public string ssAssignedToId{
  get{
      return _ssAssignedToId;
  }
  set{
      if((_ssAssignedToId!=value) || OptimizedAttributes[17]){
          ChangedAttributes[17] = true;
          _ssAssignedToId = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord() {
ChangedAttributes = new BitArray(18,true);
OptimizedAttributes = new BitArray(18,false);
_ssId = 0L;
_ssName = "";
_ssPaymentDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssProposalDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssProposalTypeId = 0;
_ssBankId = 0L;
_ssProposalStatusId = 0;
_ssFileId = 0L;
_ssTotalProposalLines = 0;
_ssTotalValueML = 0.0M;
_ssTotalValueMD = 0.0M;
_ssCurrencyId = "";
_ssRegionId = 0L;
_ssCreatedBy = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssLastUpdatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssMaxDatePaymentChanges = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssAssignedToId = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssId = r.ReadLongInteger(index++, "Proposal.Id", 0L);
ssName = r.ReadText(index++, "Proposal.Name", "");
ssPaymentDate = r.ReadDate(index++, "Proposal.PaymentDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssProposalDate = r.ReadDate(index++, "Proposal.ProposalDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssProposalTypeId = r.ReadEntityReference(index++, "Proposal.ProposalTypeId", 0);
ssBankId = r.ReadEntityReferenceLongInteger(index++, "Proposal.BankId", 0L);
ssProposalStatusId = r.ReadEntityReference(index++, "Proposal.ProposalStatusId", 0);
ssFileId = r.ReadEntityReferenceLongInteger(index++, "Proposal.FileId", 0L);
ssTotalProposalLines = r.ReadInteger(index++, "Proposal.TotalProposalLines", 0);
ssTotalValueML = r.ReadDecimal(index++, "Proposal.TotalValueML", 0.0M);
ssTotalValueMD = r.ReadDecimal(index++, "Proposal.TotalValueMD", 0.0M);
ssCurrencyId = r.ReadEntityReferenceText(index++, "Proposal.CurrencyId", "");
ssRegionId = r.ReadEntityReferenceLongInteger(index++, "Proposal.RegionId", 0L);
ssCreatedBy = r.ReadEntityReferenceText(index++, "Proposal.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "Proposal.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssLastUpdatedOn = r.ReadDateTime(index++, "Proposal.LastUpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssMaxDatePaymentChanges = r.ReadDate(index++, "Proposal.MaxDatePaymentChanges", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssAssignedToId = r.ReadEntityReferenceText(index++, "Proposal.AssignedToId", "");
ChangedAttributes = new BitArray(18,false);
OptimizedAttributes = new BitArray(18,false);
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord r) {
this = r;
}


public static bool operator == (EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord a, EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssName != b.ssName) return false;
if (a.ssPaymentDate != b.ssPaymentDate) return false;
if (a.ssProposalDate != b.ssProposalDate) return false;
if (a.ssProposalTypeId != b.ssProposalTypeId) return false;
if (a.ssBankId != b.ssBankId) return false;
if (a.ssProposalStatusId != b.ssProposalStatusId) return false;
if (a.ssFileId != b.ssFileId) return false;
if (a.ssTotalProposalLines != b.ssTotalProposalLines) return false;
if (a.ssTotalValueML != b.ssTotalValueML) return false;
if (a.ssTotalValueMD != b.ssTotalValueMD) return false;
if (a.ssCurrencyId != b.ssCurrencyId) return false;
if (a.ssRegionId != b.ssRegionId) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssLastUpdatedOn != b.ssLastUpdatedOn) return false;
if (a.ssMaxDatePaymentChanges != b.ssMaxDatePaymentChanges) return false;
if (a.ssAssignedToId != b.ssAssignedToId) return false;
return true;
}

public static bool operator != (EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord a, EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord)) return false;
return (this == (EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssPaymentDate.GetHashCode()
 ^ ssProposalDate.GetHashCode()
 ^ ssProposalTypeId.GetHashCode()
 ^ ssBankId.GetHashCode()
 ^ ssProposalStatusId.GetHashCode()
 ^ ssFileId.GetHashCode()
 ^ ssTotalProposalLines.GetHashCode()
 ^ ssTotalValueML.GetHashCode()
 ^ ssTotalValueMD.GetHashCode()
 ^ ssCurrencyId.GetHashCode()
 ^ ssRegionId.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssLastUpdatedOn.GetHashCode()
 ^ ssMaxDatePaymentChanges.GetHashCode()
 ^ ssAssignedToId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord Duplicate() {
EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord t;
t._ssId = this._ssId;
t._ssName = this._ssName;
t._ssPaymentDate = this._ssPaymentDate;
t._ssProposalDate = this._ssProposalDate;
t._ssProposalTypeId = this._ssProposalTypeId;
t._ssBankId = this._ssBankId;
t._ssProposalStatusId = this._ssProposalStatusId;
t._ssFileId = this._ssFileId;
t._ssTotalProposalLines = this._ssTotalProposalLines;
t._ssTotalValueML = this._ssTotalValueML;
t._ssTotalValueMD = this._ssTotalValueMD;
t._ssCurrencyId = this._ssCurrencyId;
t._ssRegionId = this._ssRegionId;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t._ssLastUpdatedOn = this._ssLastUpdatedOn;
t._ssMaxDatePaymentChanges = this._ssMaxDatePaymentChanges;
t._ssAssignedToId = this._ssAssignedToId;
t.ChangedAttributes = new BitArray(18);
t.OptimizedAttributes = new BitArray(18);
for(int i = 0; i < 18; i++){
  t.ChangedAttributes[i] = ChangedAttributes[i];
  t.OptimizedAttributes[i] = OptimizedAttributes[i];
}
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "paymentdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentDate")) variable.Value = ssPaymentDate; else variable.Optimized = true;
} else if (head == "proposaldate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalDate")) variable.Value = ssProposalDate; else variable.Optimized = true;
} else if (head == "proposaltypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalTypeId")) variable.Value = ssProposalTypeId; else variable.Optimized = true;
} else if (head == "bankid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BankId")) variable.Value = ssBankId; else variable.Optimized = true;
} else if (head == "proposalstatusid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalStatusId")) variable.Value = ssProposalStatusId; else variable.Optimized = true;
} else if (head == "fileid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileId")) variable.Value = ssFileId; else variable.Optimized = true;
} else if (head == "totalproposallines") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalProposalLines")) variable.Value = ssTotalProposalLines; else variable.Optimized = true;
} else if (head == "totalvalueml") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalValueML")) variable.Value = ssTotalValueML; else variable.Optimized = true;
} else if (head == "totalvaluemd") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalValueMD")) variable.Value = ssTotalValueMD; else variable.Optimized = true;
} else if (head == "currencyid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrencyId")) variable.Value = ssCurrencyId; else variable.Optimized = true;
} else if (head == "regionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionId")) variable.Value = ssRegionId; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "lastupdatedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LastUpdatedOn")) variable.Value = ssLastUpdatedOn; else variable.Optimized = true;
} else if (head == "maxdatepaymentchanges") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MaxDatePaymentChanges")) variable.Value = ssMaxDatePaymentChanges; else variable.Optimized = true;
} else if (head == "assignedtoid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AssignedToId")) variable.Value = ssAssignedToId; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdName)) {
return ChangedAttributes[1];
}
if (key.Equals(IdPaymentDate)) {
return ChangedAttributes[2];
}
if (key.Equals(IdProposalDate)) {
return ChangedAttributes[3];
}
if (key.Equals(IdProposalTypeId)) {
return ChangedAttributes[4];
}
if (key.Equals(IdBankId)) {
return ChangedAttributes[5];
}
if (key.Equals(IdProposalStatusId)) {
return ChangedAttributes[6];
}
if (key.Equals(IdFileId)) {
return ChangedAttributes[7];
}
if (key.Equals(IdTotalProposalLines)) {
return ChangedAttributes[8];
}
if (key.Equals(IdTotalValueML)) {
return ChangedAttributes[9];
}
if (key.Equals(IdTotalValueMD)) {
return ChangedAttributes[10];
}
if (key.Equals(IdCurrencyId)) {
return ChangedAttributes[11];
}
if (key.Equals(IdRegionId)) {
return ChangedAttributes[12];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[13];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[14];
}
if (key.Equals(IdLastUpdatedOn)) {
return ChangedAttributes[15];
}
if (key.Equals(IdMaxDatePaymentChanges)) {
return ChangedAttributes[16];
}
if (key.Equals(IdAssignedToId)) {
return ChangedAttributes[17];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdName)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdPaymentDate)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdProposalDate)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdProposalTypeId)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdBankId)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdProposalStatusId)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdFileId)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdTotalProposalLines)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdTotalValueML)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdTotalValueMD)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdCurrencyId)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdRegionId)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[14];
}
if (key.Equals(IdLastUpdatedOn)) {
return OptimizedAttributes[15];
}
if (key.Equals(IdMaxDatePaymentChanges)) {
return OptimizedAttributes[16];
}
if (key.Equals(IdAssignedToId)) {
return OptimizedAttributes[17];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdName) {
return ssName;
}
if (key == IdPaymentDate) {
return ssPaymentDate;
}
if (key == IdProposalDate) {
return ssProposalDate;
}
if (key == IdProposalTypeId) {
return ssProposalTypeId;
}
if (key == IdBankId) {
return ssBankId;
}
if (key == IdProposalStatusId) {
return ssProposalStatusId;
}
if (key == IdFileId) {
return ssFileId;
}
if (key == IdTotalProposalLines) {
return ssTotalProposalLines;
}
if (key == IdTotalValueML) {
return ssTotalValueML;
}
if (key == IdTotalValueMD) {
return ssTotalValueMD;
}
if (key == IdCurrencyId) {
return ssCurrencyId;
}
if (key == IdRegionId) {
return ssRegionId;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdLastUpdatedOn) {
return ssLastUpdatedOn;
}
if (key == IdMaxDatePaymentChanges) {
return ssMaxDatePaymentChanges;
}
if (key == IdAssignedToId) {
return ssAssignedToId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdPaymentDate.Key.AsGuid) {
return ssPaymentDate;
}
if (attributeKey == IdProposalDate.Key.AsGuid) {
return ssProposalDate;
}
if (attributeKey == IdProposalTypeId.Key.AsGuid) {
return ssProposalTypeId;
}
if (attributeKey == IdBankId.Key.AsGuid) {
return ssBankId;
}
if (attributeKey == IdProposalStatusId.Key.AsGuid) {
return ssProposalStatusId;
}
if (attributeKey == IdFileId.Key.AsGuid) {
return ssFileId;
}
if (attributeKey == IdTotalProposalLines.Key.AsGuid) {
return ssTotalProposalLines;
}
if (attributeKey == IdTotalValueML.Key.AsGuid) {
return ssTotalValueML;
}
if (attributeKey == IdTotalValueMD.Key.AsGuid) {
return ssTotalValueMD;
}
if (attributeKey == IdCurrencyId.Key.AsGuid) {
return ssCurrencyId;
}
if (attributeKey == IdRegionId.Key.AsGuid) {
return ssRegionId;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdLastUpdatedOn.Key.AsGuid) {
return ssLastUpdatedOn;
}
if (attributeKey == IdMaxDatePaymentChanges.Key.AsGuid) {
return ssMaxDatePaymentChanges;
}
if (attributeKey == IdAssignedToId.Key.AsGuid) {
return ssAssignedToId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(18);
OptimizedAttributes = new BitArray(18);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssName = (string) other.AttributeGet(IdName);
ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
ssPaymentDate = (DateTime) other.AttributeGet(IdPaymentDate);
ChangedAttributes[2] = other.ChangedAttributeGet(IdPaymentDate);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdPaymentDate);
ssProposalDate = (DateTime) other.AttributeGet(IdProposalDate);
ChangedAttributes[3] = other.ChangedAttributeGet(IdProposalDate);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdProposalDate);
ssProposalTypeId = (int) other.AttributeGet(IdProposalTypeId);
ChangedAttributes[4] = other.ChangedAttributeGet(IdProposalTypeId);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdProposalTypeId);
ssBankId = (long) other.AttributeGet(IdBankId);
ChangedAttributes[5] = other.ChangedAttributeGet(IdBankId);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdBankId);
ssProposalStatusId = (int) other.AttributeGet(IdProposalStatusId);
ChangedAttributes[6] = other.ChangedAttributeGet(IdProposalStatusId);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdProposalStatusId);
ssFileId = (long) other.AttributeGet(IdFileId);
ChangedAttributes[7] = other.ChangedAttributeGet(IdFileId);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdFileId);
ssTotalProposalLines = (int) other.AttributeGet(IdTotalProposalLines);
ChangedAttributes[8] = other.ChangedAttributeGet(IdTotalProposalLines);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdTotalProposalLines);
ssTotalValueML = (decimal) other.AttributeGet(IdTotalValueML);
ChangedAttributes[9] = other.ChangedAttributeGet(IdTotalValueML);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdTotalValueML);
ssTotalValueMD = (decimal) other.AttributeGet(IdTotalValueMD);
ChangedAttributes[10] = other.ChangedAttributeGet(IdTotalValueMD);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdTotalValueMD);
ssCurrencyId = (string) other.AttributeGet(IdCurrencyId);
ChangedAttributes[11] = other.ChangedAttributeGet(IdCurrencyId);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdCurrencyId);
ssRegionId = (long) other.AttributeGet(IdRegionId);
ChangedAttributes[12] = other.ChangedAttributeGet(IdRegionId);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdRegionId);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[13] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[14] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdCreatedOn);
ssLastUpdatedOn = (DateTime) other.AttributeGet(IdLastUpdatedOn);
ChangedAttributes[15] = other.ChangedAttributeGet(IdLastUpdatedOn);
OptimizedAttributes[15] = other.OptimizedAttributeGet(IdLastUpdatedOn);
ssMaxDatePaymentChanges = (DateTime) other.AttributeGet(IdMaxDatePaymentChanges);
ChangedAttributes[16] = other.ChangedAttributeGet(IdMaxDatePaymentChanges);
OptimizedAttributes[16] = other.OptimizedAttributeGet(IdMaxDatePaymentChanges);
ssAssignedToId = (string) other.AttributeGet(IdAssignedToId);
ChangedAttributes[17] = other.ChangedAttributeGet(IdAssignedToId);
OptimizedAttributes[17] = other.OptimizedAttributeGet(IdAssignedToId);
}
} // EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord

/// <summary>
/// RecordList type <code>ProposalList</code> that represents a record list of <code>Proposal</code>
/// </summary>
public partial class RL_c86530363dd14ad1cb7fed94caf7eb01 : GenericRecordList<EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord>, IEnumerable, IEnumerator {

protected override EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord GetElementDefaultValue() {
return new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord();
}

public T[] ToArray<T>(Func<EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c86530363dd14ad1cb7fed94caf7eb01 recordList, Func<EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c86530363dd14ad1cb7fed94caf7eb01(EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord[] array) {
  RL_c86530363dd14ad1cb7fed94caf7eb01 result = new RL_c86530363dd14ad1cb7fed94caf7eb01();
result.InnerFromArray(array);
    return result;
}

public static RL_c86530363dd14ad1cb7fed94caf7eb01 ToList<T>(T[] array, Func <T, EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord> converter) {
  RL_c86530363dd14ad1cb7fed94caf7eb01 result = new RL_c86530363dd14ad1cb7fed94caf7eb01();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c86530363dd14ad1cb7fed94caf7eb01 FromRestList<T>(RestList<T> restList, Func <T, EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord> converter) {
  RL_c86530363dd14ad1cb7fed94caf7eb01 result = new RL_c86530363dd14ad1cb7fed94caf7eb01();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c86530363dd14ad1cb7fed94caf7eb01() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord> NewList() {
return new RL_c86530363dd14ad1cb7fed94caf7eb01();
}


} // RL_c86530363dd14ad1cb7fed94caf7eb01
}
