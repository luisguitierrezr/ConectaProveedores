using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] Reassignments (XN__L4e9YE2e8G7uvCKL3g)
///  <code>EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord</code> that represent
/// s <code>Reassignments</code> <p>Description: Reassignment</p>
/// </summary>
// Name: Reassignments
public partial struct EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord : ITypedRecord<EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*v8hhK3QH_k+ew0Zp4xvqSQ");
internal static readonly GlobalObjectKey IdSourceUserId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*mRT2o_Oz7E2oJsvERXURgg");
internal static readonly GlobalObjectKey IdTargetUserId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*W2r4yxK4ZE+xoZvip9n7XQ");
internal static readonly GlobalObjectKey IdRequisitionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_MxS3i_6F0OY0C0Pj2KSsQ");
internal static readonly GlobalObjectKey IdRequisitionApprovalLevelId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*rq9ydE7DY0uttQkBdZMO_A");
internal static readonly GlobalObjectKey IdInvoiceId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ehjE9RjyV0ukdFfOFOjpkA");
internal static readonly GlobalObjectKey IdInvoiceApprovalLevelId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*5dNdiToLoU66kMVJh4sefA");
internal static readonly GlobalObjectKey IdReason = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*MZqQoh0N70ahUTdmpqZTSA");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*rjjs8nhQIUSBBu2v0CuvaQ");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ip1Tf5GW4EeGn2_SYy41Eg");
internal static readonly GlobalObjectKey IdRevokedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*fv2N8N6P7EK7knNgO4wwhA");
internal static readonly GlobalObjectKey IdRevokedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Yw6zfS32_Eu1vTyqBIDBWQ");
internal static readonly GlobalObjectKey IdFolioId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*2CetjHVaiEeqNSehLQbqZg");
internal static readonly GlobalObjectKey IdFolioApprovalLevelId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*d80TtHJCQUmSNUzU1j9I4w");
internal static readonly GlobalObjectKey IdSourceEntraRoleId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*b+exnoe4KEawFlXkot9JYw");
internal static readonly GlobalObjectKey IdTargetEntraRoleId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*nRU6EB71zUGK19CH+bxsRg");
internal static readonly GlobalObjectKey IdIsFolioApprovalLevelInvoice = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hx2Y2rJgoEiitH2rLflV_w");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(17,true);
          _ssId = value;
      }
  }
}

private string _ssSourceUserId;
public string ssSourceUserId{
  get{
      return _ssSourceUserId;
  }
  set{
      if((_ssSourceUserId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssSourceUserId = value;
      }
  }
}

private string _ssTargetUserId;
public string ssTargetUserId{
  get{
      return _ssTargetUserId;
  }
  set{
      if((_ssTargetUserId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssTargetUserId = value;
      }
  }
}

private long _ssRequisitionId;
public long ssRequisitionId{
  get{
      return _ssRequisitionId;
  }
  set{
      if((_ssRequisitionId!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssRequisitionId = value;
      }
  }
}

private long _ssRequisitionApprovalLevelId;
public long ssRequisitionApprovalLevelId{
  get{
      return _ssRequisitionApprovalLevelId;
  }
  set{
      if((_ssRequisitionApprovalLevelId!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssRequisitionApprovalLevelId = value;
      }
  }
}

private long _ssInvoiceId;
public long ssInvoiceId{
  get{
      return _ssInvoiceId;
  }
  set{
      if((_ssInvoiceId!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssInvoiceId = value;
      }
  }
}

private long _ssInvoiceApprovalLevelId;
public long ssInvoiceApprovalLevelId{
  get{
      return _ssInvoiceApprovalLevelId;
  }
  set{
      if((_ssInvoiceApprovalLevelId!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssInvoiceApprovalLevelId = value;
      }
  }
}

private string _ssReason;
public string ssReason{
  get{
      return _ssReason;
  }
  set{
      if((_ssReason!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssReason = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
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
      if((_ssCreatedOn!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssCreatedOn = value;
      }
  }
}

private string _ssRevokedBy;
public string ssRevokedBy{
  get{
      return _ssRevokedBy;
  }
  set{
      if((_ssRevokedBy!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssRevokedBy = value;
      }
  }
}

private DateTime _ssRevokedOn;
public DateTime ssRevokedOn{
  get{
      return _ssRevokedOn;
  }
  set{
      if((_ssRevokedOn!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssRevokedOn = value;
      }
  }
}

private long _ssFolioId;
public long ssFolioId{
  get{
      return _ssFolioId;
  }
  set{
      if((_ssFolioId!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssFolioId = value;
      }
  }
}

private long _ssFolioApprovalLevelId;
public long ssFolioApprovalLevelId{
  get{
      return _ssFolioApprovalLevelId;
  }
  set{
      if((_ssFolioApprovalLevelId!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssFolioApprovalLevelId = value;
      }
  }
}

private long _ssSourceEntraRoleId;
public long ssSourceEntraRoleId{
  get{
      return _ssSourceEntraRoleId;
  }
  set{
      if((_ssSourceEntraRoleId!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
          _ssSourceEntraRoleId = value;
      }
  }
}

private long _ssTargetEntraRoleId;
public long ssTargetEntraRoleId{
  get{
      return _ssTargetEntraRoleId;
  }
  set{
      if((_ssTargetEntraRoleId!=value) || OptimizedAttributes[15]){
          ChangedAttributes[15] = true;
          _ssTargetEntraRoleId = value;
      }
  }
}

private bool _ssIsFolioApprovalLevelInvoice;
public bool ssIsFolioApprovalLevelInvoice{
  get{
      return _ssIsFolioApprovalLevelInvoice;
  }
  set{
      if((_ssIsFolioApprovalLevelInvoice!=value) || OptimizedAttributes[16]){
          ChangedAttributes[16] = true;
          _ssIsFolioApprovalLevelInvoice = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord() {
ChangedAttributes = new BitArray(17,true);
OptimizedAttributes = new BitArray(17,false);
_ssId = 0L;
_ssSourceUserId = "";
_ssTargetUserId = "";
_ssRequisitionId = 0L;
_ssRequisitionApprovalLevelId = 0L;
_ssInvoiceId = 0L;
_ssInvoiceApprovalLevelId = 0L;
_ssReason = "";
_ssCreatedBy = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssRevokedBy = "";
_ssRevokedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssFolioId = 0L;
_ssFolioApprovalLevelId = 0L;
_ssSourceEntraRoleId = 0L;
_ssTargetEntraRoleId = 0L;
_ssIsFolioApprovalLevelInvoice = false;
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
ssId = r.ReadLongInteger(index++, "Reassignments.Id", 0L);
ssSourceUserId = r.ReadEntityReferenceText(index++, "Reassignments.SourceUserId", "");
ssTargetUserId = r.ReadEntityReferenceText(index++, "Reassignments.TargetUserId", "");
ssRequisitionId = r.ReadEntityReferenceLongInteger(index++, "Reassignments.RequisitionId", 0L);
ssRequisitionApprovalLevelId = r.ReadEntityReferenceLongInteger(index++, "Reassignments.RequisitionApprovalLevelId", 0L);
ssInvoiceId = r.ReadEntityReferenceLongInteger(index++, "Reassignments.InvoiceId", 0L);
ssInvoiceApprovalLevelId = r.ReadEntityReferenceLongInteger(index++, "Reassignments.InvoiceApprovalLevelId", 0L);
ssReason = r.ReadText(index++, "Reassignments.Reason", "");
ssCreatedBy = r.ReadEntityReferenceText(index++, "Reassignments.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "Reassignments.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssRevokedBy = r.ReadEntityReferenceText(index++, "Reassignments.RevokedBy", "");
ssRevokedOn = r.ReadDateTime(index++, "Reassignments.RevokedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssFolioId = r.ReadEntityReferenceLongInteger(index++, "Reassignments.FolioId", 0L);
ssFolioApprovalLevelId = r.ReadEntityReferenceLongInteger(index++, "Reassignments.FolioApprovalLevelId", 0L);
ssSourceEntraRoleId = r.ReadEntityReferenceLongInteger(index++, "Reassignments.SourceEntraRoleId", 0L);
ssTargetEntraRoleId = r.ReadEntityReferenceLongInteger(index++, "Reassignments.TargetEntraRoleId", 0L);
ssIsFolioApprovalLevelInvoice = r.ReadBoolean(index++, "Reassignments.IsFolioApprovalLevelInvoice", false);
ChangedAttributes = new BitArray(17,false);
OptimizedAttributes = new BitArray(17,false);
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
public void ReadIM(EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord r) {
this = r;
}


public static bool operator == (EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord a, EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssSourceUserId != b.ssSourceUserId) return false;
if (a.ssTargetUserId != b.ssTargetUserId) return false;
if (a.ssRequisitionId != b.ssRequisitionId) return false;
if (a.ssRequisitionApprovalLevelId != b.ssRequisitionApprovalLevelId) return false;
if (a.ssInvoiceId != b.ssInvoiceId) return false;
if (a.ssInvoiceApprovalLevelId != b.ssInvoiceApprovalLevelId) return false;
if (a.ssReason != b.ssReason) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssRevokedBy != b.ssRevokedBy) return false;
if (a.ssRevokedOn != b.ssRevokedOn) return false;
if (a.ssFolioId != b.ssFolioId) return false;
if (a.ssFolioApprovalLevelId != b.ssFolioApprovalLevelId) return false;
if (a.ssSourceEntraRoleId != b.ssSourceEntraRoleId) return false;
if (a.ssTargetEntraRoleId != b.ssTargetEntraRoleId) return false;
if (a.ssIsFolioApprovalLevelInvoice != b.ssIsFolioApprovalLevelInvoice) return false;
return true;
}

public static bool operator != (EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord a, EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord)) return false;
return (this == (EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssSourceUserId.GetHashCode()
 ^ ssTargetUserId.GetHashCode()
 ^ ssRequisitionId.GetHashCode()
 ^ ssRequisitionApprovalLevelId.GetHashCode()
 ^ ssInvoiceId.GetHashCode()
 ^ ssInvoiceApprovalLevelId.GetHashCode()
 ^ ssReason.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssRevokedBy.GetHashCode()
 ^ ssRevokedOn.GetHashCode()
 ^ ssFolioId.GetHashCode()
 ^ ssFolioApprovalLevelId.GetHashCode()
 ^ ssSourceEntraRoleId.GetHashCode()
 ^ ssTargetEntraRoleId.GetHashCode()
 ^ ssIsFolioApprovalLevelInvoice.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord Duplicate() {
EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord t;
t._ssId = this._ssId;
t._ssSourceUserId = this._ssSourceUserId;
t._ssTargetUserId = this._ssTargetUserId;
t._ssRequisitionId = this._ssRequisitionId;
t._ssRequisitionApprovalLevelId = this._ssRequisitionApprovalLevelId;
t._ssInvoiceId = this._ssInvoiceId;
t._ssInvoiceApprovalLevelId = this._ssInvoiceApprovalLevelId;
t._ssReason = this._ssReason;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t._ssRevokedBy = this._ssRevokedBy;
t._ssRevokedOn = this._ssRevokedOn;
t._ssFolioId = this._ssFolioId;
t._ssFolioApprovalLevelId = this._ssFolioApprovalLevelId;
t._ssSourceEntraRoleId = this._ssSourceEntraRoleId;
t._ssTargetEntraRoleId = this._ssTargetEntraRoleId;
t._ssIsFolioApprovalLevelInvoice = this._ssIsFolioApprovalLevelInvoice;
t.ChangedAttributes = new BitArray(17);
t.OptimizedAttributes = new BitArray(17);
for(int i = 0; i < 17; i++){
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
} else if (head == "sourceuserid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SourceUserId")) variable.Value = ssSourceUserId; else variable.Optimized = true;
} else if (head == "targetuserid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TargetUserId")) variable.Value = ssTargetUserId; else variable.Optimized = true;
} else if (head == "requisitionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionId")) variable.Value = ssRequisitionId; else variable.Optimized = true;
} else if (head == "requisitionapprovallevelid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionApprovalLevelId")) variable.Value = ssRequisitionApprovalLevelId; else variable.Optimized = true;
} else if (head == "invoiceid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceId")) variable.Value = ssInvoiceId; else variable.Optimized = true;
} else if (head == "invoiceapprovallevelid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApprovalLevelId")) variable.Value = ssInvoiceApprovalLevelId; else variable.Optimized = true;
} else if (head == "reason") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Reason")) variable.Value = ssReason; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "revokedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RevokedBy")) variable.Value = ssRevokedBy; else variable.Optimized = true;
} else if (head == "revokedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RevokedOn")) variable.Value = ssRevokedOn; else variable.Optimized = true;
} else if (head == "folioid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioId")) variable.Value = ssFolioId; else variable.Optimized = true;
} else if (head == "folioapprovallevelid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioApprovalLevelId")) variable.Value = ssFolioApprovalLevelId; else variable.Optimized = true;
} else if (head == "sourceentraroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SourceEntraRoleId")) variable.Value = ssSourceEntraRoleId; else variable.Optimized = true;
} else if (head == "targetentraroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TargetEntraRoleId")) variable.Value = ssTargetEntraRoleId; else variable.Optimized = true;
} else if (head == "isfolioapprovallevelinvoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsFolioApprovalLevelInvoice")) variable.Value = ssIsFolioApprovalLevelInvoice; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdSourceUserId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdTargetUserId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdRequisitionId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdRequisitionApprovalLevelId)) {
return ChangedAttributes[4];
}
if (key.Equals(IdInvoiceId)) {
return ChangedAttributes[5];
}
if (key.Equals(IdInvoiceApprovalLevelId)) {
return ChangedAttributes[6];
}
if (key.Equals(IdReason)) {
return ChangedAttributes[7];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[8];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[9];
}
if (key.Equals(IdRevokedBy)) {
return ChangedAttributes[10];
}
if (key.Equals(IdRevokedOn)) {
return ChangedAttributes[11];
}
if (key.Equals(IdFolioId)) {
return ChangedAttributes[12];
}
if (key.Equals(IdFolioApprovalLevelId)) {
return ChangedAttributes[13];
}
if (key.Equals(IdSourceEntraRoleId)) {
return ChangedAttributes[14];
}
if (key.Equals(IdTargetEntraRoleId)) {
return ChangedAttributes[15];
}
if (key.Equals(IdIsFolioApprovalLevelInvoice)) {
return ChangedAttributes[16];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdSourceUserId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdTargetUserId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdRequisitionId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdRequisitionApprovalLevelId)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdInvoiceId)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdInvoiceApprovalLevelId)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdReason)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdRevokedBy)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdRevokedOn)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdFolioId)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdFolioApprovalLevelId)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdSourceEntraRoleId)) {
return OptimizedAttributes[14];
}
if (key.Equals(IdTargetEntraRoleId)) {
return OptimizedAttributes[15];
}
if (key.Equals(IdIsFolioApprovalLevelInvoice)) {
return OptimizedAttributes[16];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdSourceUserId) {
return ssSourceUserId;
}
if (key == IdTargetUserId) {
return ssTargetUserId;
}
if (key == IdRequisitionId) {
return ssRequisitionId;
}
if (key == IdRequisitionApprovalLevelId) {
return ssRequisitionApprovalLevelId;
}
if (key == IdInvoiceId) {
return ssInvoiceId;
}
if (key == IdInvoiceApprovalLevelId) {
return ssInvoiceApprovalLevelId;
}
if (key == IdReason) {
return ssReason;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdRevokedBy) {
return ssRevokedBy;
}
if (key == IdRevokedOn) {
return ssRevokedOn;
}
if (key == IdFolioId) {
return ssFolioId;
}
if (key == IdFolioApprovalLevelId) {
return ssFolioApprovalLevelId;
}
if (key == IdSourceEntraRoleId) {
return ssSourceEntraRoleId;
}
if (key == IdTargetEntraRoleId) {
return ssTargetEntraRoleId;
}
if (key == IdIsFolioApprovalLevelInvoice) {
return ssIsFolioApprovalLevelInvoice;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdSourceUserId.Key.AsGuid) {
return ssSourceUserId;
}
if (attributeKey == IdTargetUserId.Key.AsGuid) {
return ssTargetUserId;
}
if (attributeKey == IdRequisitionId.Key.AsGuid) {
return ssRequisitionId;
}
if (attributeKey == IdRequisitionApprovalLevelId.Key.AsGuid) {
return ssRequisitionApprovalLevelId;
}
if (attributeKey == IdInvoiceId.Key.AsGuid) {
return ssInvoiceId;
}
if (attributeKey == IdInvoiceApprovalLevelId.Key.AsGuid) {
return ssInvoiceApprovalLevelId;
}
if (attributeKey == IdReason.Key.AsGuid) {
return ssReason;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdRevokedBy.Key.AsGuid) {
return ssRevokedBy;
}
if (attributeKey == IdRevokedOn.Key.AsGuid) {
return ssRevokedOn;
}
if (attributeKey == IdFolioId.Key.AsGuid) {
return ssFolioId;
}
if (attributeKey == IdFolioApprovalLevelId.Key.AsGuid) {
return ssFolioApprovalLevelId;
}
if (attributeKey == IdSourceEntraRoleId.Key.AsGuid) {
return ssSourceEntraRoleId;
}
if (attributeKey == IdTargetEntraRoleId.Key.AsGuid) {
return ssTargetEntraRoleId;
}
if (attributeKey == IdIsFolioApprovalLevelInvoice.Key.AsGuid) {
return ssIsFolioApprovalLevelInvoice;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(17);
OptimizedAttributes = new BitArray(17);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssSourceUserId = (string) other.AttributeGet(IdSourceUserId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdSourceUserId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdSourceUserId);
ssTargetUserId = (string) other.AttributeGet(IdTargetUserId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdTargetUserId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdTargetUserId);
ssRequisitionId = (long) other.AttributeGet(IdRequisitionId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdRequisitionId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdRequisitionId);
ssRequisitionApprovalLevelId = (long) other.AttributeGet(IdRequisitionApprovalLevelId);
ChangedAttributes[4] = other.ChangedAttributeGet(IdRequisitionApprovalLevelId);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdRequisitionApprovalLevelId);
ssInvoiceId = (long) other.AttributeGet(IdInvoiceId);
ChangedAttributes[5] = other.ChangedAttributeGet(IdInvoiceId);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdInvoiceId);
ssInvoiceApprovalLevelId = (long) other.AttributeGet(IdInvoiceApprovalLevelId);
ChangedAttributes[6] = other.ChangedAttributeGet(IdInvoiceApprovalLevelId);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdInvoiceApprovalLevelId);
ssReason = (string) other.AttributeGet(IdReason);
ChangedAttributes[7] = other.ChangedAttributeGet(IdReason);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdReason);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[8] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[9] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdCreatedOn);
ssRevokedBy = (string) other.AttributeGet(IdRevokedBy);
ChangedAttributes[10] = other.ChangedAttributeGet(IdRevokedBy);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdRevokedBy);
ssRevokedOn = (DateTime) other.AttributeGet(IdRevokedOn);
ChangedAttributes[11] = other.ChangedAttributeGet(IdRevokedOn);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdRevokedOn);
ssFolioId = (long) other.AttributeGet(IdFolioId);
ChangedAttributes[12] = other.ChangedAttributeGet(IdFolioId);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdFolioId);
ssFolioApprovalLevelId = (long) other.AttributeGet(IdFolioApprovalLevelId);
ChangedAttributes[13] = other.ChangedAttributeGet(IdFolioApprovalLevelId);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdFolioApprovalLevelId);
ssSourceEntraRoleId = (long) other.AttributeGet(IdSourceEntraRoleId);
ChangedAttributes[14] = other.ChangedAttributeGet(IdSourceEntraRoleId);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdSourceEntraRoleId);
ssTargetEntraRoleId = (long) other.AttributeGet(IdTargetEntraRoleId);
ChangedAttributes[15] = other.ChangedAttributeGet(IdTargetEntraRoleId);
OptimizedAttributes[15] = other.OptimizedAttributeGet(IdTargetEntraRoleId);
ssIsFolioApprovalLevelInvoice = (bool) other.AttributeGet(IdIsFolioApprovalLevelInvoice);
ChangedAttributes[16] = other.ChangedAttributeGet(IdIsFolioApprovalLevelInvoice);
OptimizedAttributes[16] = other.OptimizedAttributeGet(IdIsFolioApprovalLevelInvoice);
}
} // EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord

/// <summary>
/// RecordList type <code>ReassignmentsList</code> that represents a record list of
///  <code>Reassignments</code>
/// </summary>
public partial class RL_1baaef4f70e46e094f278bb36a3e6c6e : GenericRecordList<EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord>, IEnumerable, IEnumerator {

protected override EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord GetElementDefaultValue() {
return new EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord();
}

public T[] ToArray<T>(Func<EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1baaef4f70e46e094f278bb36a3e6c6e recordList, Func<EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1baaef4f70e46e094f278bb36a3e6c6e(EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord[] array) {
  RL_1baaef4f70e46e094f278bb36a3e6c6e result = new RL_1baaef4f70e46e094f278bb36a3e6c6e();
result.InnerFromArray(array);
    return result;
}

public static RL_1baaef4f70e46e094f278bb36a3e6c6e ToList<T>(T[] array, Func <T, EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord> converter) {
  RL_1baaef4f70e46e094f278bb36a3e6c6e result = new RL_1baaef4f70e46e094f278bb36a3e6c6e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1baaef4f70e46e094f278bb36a3e6c6e FromRestList<T>(RestList<T> restList, Func <T, EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord> converter) {
  RL_1baaef4f70e46e094f278bb36a3e6c6e result = new RL_1baaef4f70e46e094f278bb36a3e6c6e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1baaef4f70e46e094f278bb36a3e6c6e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord> NewList() {
return new RL_1baaef4f70e46e094f278bb36a3e6c6e();
}


} // RL_1baaef4f70e46e094f278bb36a3e6c6e
}
