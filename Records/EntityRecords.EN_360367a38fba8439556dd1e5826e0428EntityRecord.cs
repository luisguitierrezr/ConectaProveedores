using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] SupplierUser (AsESXqR4aUCiJTlpUDNTmA)
///  <code>EN_360367a38fba8439556dd1e5826e0428EntityRecord</code> that represent
/// s <code>SupplierUser</code> <p>Description: User from supplier</p>
/// </summary>
// Name: SupplierUser
public partial struct EN_360367a38fba8439556dd1e5826e0428EntityRecord : ITypedRecord<EN_360367a38fba8439556dd1e5826e0428EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*1Noa9AZKrUW9PIJe1ACUFQ");
internal static readonly GlobalObjectKey IdSupplierId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*YBLbCaU260ONAfvRmkjIxA");
internal static readonly GlobalObjectKey IdUserId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*yFhxHqpWN0ecxybQbDtyZQ");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*QD63StZ1gEutrOMb1tv_2Q");
internal static readonly GlobalObjectKey IdEmail = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*6h6xBpTKNUCngxsL+67FdA");
internal static readonly GlobalObjectKey IdActivationEmailSentDate = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*aUm8yyuXeEm5FIVWHcB5Lw");
internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*J4OWt_CeQk6QBC+kWu7LRQ");
internal static readonly GlobalObjectKey IdIsDeleted = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*VnHa4CUCdkOkXZMI0tuRhg");
internal static readonly GlobalObjectKey IdIsBlocked = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*bF+PcyavFkC7vjCBHu4a1Q");
internal static readonly GlobalObjectKey IdBlockedUntil = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*pW7A4btkpkykKTpT4yZ0eQ");
internal static readonly GlobalObjectKey IdLastLoginDate = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*iGcD8ycPPUuGXjuD43c6cg");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*gMFvWUcRZkqRlR4gHHO+4g");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*a6TYcqWOwkObZc_6BgKGcQ");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*CzolWhOrWU+O2dhByYkKaA");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*l7GfSmY6n0Ko6W1FDz4fvg");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(15,true);
          _ssId = value;
      }
  }
}

private long _ssSupplierId;
public long ssSupplierId{
  get{
      return _ssSupplierId;
  }
  set{
      if((_ssSupplierId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssSupplierId = value;
      }
  }
}

private string _ssUserId;
public string ssUserId{
  get{
      return _ssUserId;
  }
  set{
      if((_ssUserId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssUserId = value;
      }
  }
}

private string _ssName;
public string ssName{
  get{
      return _ssName;
  }
  set{
      if((_ssName!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssName = value;
      }
  }
}

private string _ssEmail;
public string ssEmail{
  get{
      return _ssEmail;
  }
  set{
      if((_ssEmail!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssEmail = value;
      }
  }
}

private DateTime _ssActivationEmailSentDate;
public DateTime ssActivationEmailSentDate{
  get{
      return _ssActivationEmailSentDate;
  }
  set{
      if((_ssActivationEmailSentDate!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssActivationEmailSentDate = value;
      }
  }
}

private bool _ssIsActive;
public bool ssIsActive{
  get{
      return _ssIsActive;
  }
  set{
      if((_ssIsActive!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssIsActive = value;
      }
  }
}

private bool _ssIsDeleted;
public bool ssIsDeleted{
  get{
      return _ssIsDeleted;
  }
  set{
      if((_ssIsDeleted!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssIsDeleted = value;
      }
  }
}

private bool _ssIsBlocked;
public bool ssIsBlocked{
  get{
      return _ssIsBlocked;
  }
  set{
      if((_ssIsBlocked!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssIsBlocked = value;
      }
  }
}

private DateTime _ssBlockedUntil;
public DateTime ssBlockedUntil{
  get{
      return _ssBlockedUntil;
  }
  set{
      if((_ssBlockedUntil!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssBlockedUntil = value;
      }
  }
}

private DateTime _ssLastLoginDate;
public DateTime ssLastLoginDate{
  get{
      return _ssLastLoginDate;
  }
  set{
      if((_ssLastLoginDate!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssLastLoginDate = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
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
      if((_ssCreatedOn!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssCreatedOn = value;
      }
  }
}

private string _ssUpdatedBy;
public string ssUpdatedBy{
  get{
      return _ssUpdatedBy;
  }
  set{
      if((_ssUpdatedBy!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssUpdatedBy = value;
      }
  }
}

private DateTime _ssUpdatedOn;
public DateTime ssUpdatedOn{
  get{
      return _ssUpdatedOn;
  }
  set{
      if((_ssUpdatedOn!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
          _ssUpdatedOn = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_360367a38fba8439556dd1e5826e0428EntityRecord() {
ChangedAttributes = new BitArray(15,true);
OptimizedAttributes = new BitArray(15,false);
_ssId = 0L;
_ssSupplierId = 0L;
_ssUserId = "";
_ssName = "";
_ssEmail = "";
_ssActivationEmailSentDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssIsActive = false;
_ssIsDeleted = false;
_ssIsBlocked = false;
_ssBlockedUntil = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssLastLoginDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssCreatedBy = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssUpdatedBy = "";
_ssUpdatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
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
ssId = r.ReadLongInteger(index++, "SupplierUser.Id", 0L);
ssSupplierId = r.ReadEntityReferenceLongInteger(index++, "SupplierUser.SupplierId", 0L);
ssUserId = r.ReadEntityReferenceText(index++, "SupplierUser.UserId", "");
ssName = r.ReadText(index++, "SupplierUser.Name", "");
ssEmail = r.ReadEmail(index++, "SupplierUser.Email", "");
ssActivationEmailSentDate = r.ReadDateTime(index++, "SupplierUser.ActivationEmailSentDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssIsActive = r.ReadBoolean(index++, "SupplierUser.IsActive", false);
ssIsDeleted = r.ReadBoolean(index++, "SupplierUser.IsDeleted", false);
ssIsBlocked = r.ReadBoolean(index++, "SupplierUser.IsBlocked", false);
ssBlockedUntil = r.ReadDateTime(index++, "SupplierUser.BlockedUntil", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssLastLoginDate = r.ReadDateTime(index++, "SupplierUser.LastLoginDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "SupplierUser.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "SupplierUser.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "SupplierUser.UpdatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "SupplierUser.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ChangedAttributes = new BitArray(15,false);
OptimizedAttributes = new BitArray(15,false);
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
public void ReadIM(EN_360367a38fba8439556dd1e5826e0428EntityRecord r) {
this = r;
}


public static bool operator == (EN_360367a38fba8439556dd1e5826e0428EntityRecord a, EN_360367a38fba8439556dd1e5826e0428EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssSupplierId != b.ssSupplierId) return false;
if (a.ssUserId != b.ssUserId) return false;
if (a.ssName != b.ssName) return false;
if (a.ssEmail != b.ssEmail) return false;
if (a.ssActivationEmailSentDate != b.ssActivationEmailSentDate) return false;
if (a.ssIsActive != b.ssIsActive) return false;
if (a.ssIsDeleted != b.ssIsDeleted) return false;
if (a.ssIsBlocked != b.ssIsBlocked) return false;
if (a.ssBlockedUntil != b.ssBlockedUntil) return false;
if (a.ssLastLoginDate != b.ssLastLoginDate) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
return true;
}

public static bool operator != (EN_360367a38fba8439556dd1e5826e0428EntityRecord a, EN_360367a38fba8439556dd1e5826e0428EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_360367a38fba8439556dd1e5826e0428EntityRecord)) return false;
return (this == (EN_360367a38fba8439556dd1e5826e0428EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssSupplierId.GetHashCode()
 ^ ssUserId.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssEmail.GetHashCode()
 ^ ssActivationEmailSentDate.GetHashCode()
 ^ ssIsActive.GetHashCode()
 ^ ssIsDeleted.GetHashCode()
 ^ ssIsBlocked.GetHashCode()
 ^ ssBlockedUntil.GetHashCode()
 ^ ssLastLoginDate.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssUpdatedBy.GetHashCode()
 ^ ssUpdatedOn.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_360367a38fba8439556dd1e5826e0428EntityRecord Duplicate() {
EN_360367a38fba8439556dd1e5826e0428EntityRecord t;
t._ssId = this._ssId;
t._ssSupplierId = this._ssSupplierId;
t._ssUserId = this._ssUserId;
t._ssName = this._ssName;
t._ssEmail = this._ssEmail;
t._ssActivationEmailSentDate = this._ssActivationEmailSentDate;
t._ssIsActive = this._ssIsActive;
t._ssIsDeleted = this._ssIsDeleted;
t._ssIsBlocked = this._ssIsBlocked;
t._ssBlockedUntil = this._ssBlockedUntil;
t._ssLastLoginDate = this._ssLastLoginDate;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t.ChangedAttributes = new BitArray(15);
t.OptimizedAttributes = new BitArray(15);
for(int i = 0; i < 15; i++){
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
} else if (head == "supplierid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierId")) variable.Value = ssSupplierId; else variable.Optimized = true;
} else if (head == "userid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserId")) variable.Value = ssUserId; else variable.Optimized = true;
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "email") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Email")) variable.Value = ssEmail; else variable.Optimized = true;
} else if (head == "activationemailsentdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ActivationEmailSentDate")) variable.Value = ssActivationEmailSentDate; else variable.Optimized = true;
} else if (head == "isactive") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
} else if (head == "isdeleted") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsDeleted")) variable.Value = ssIsDeleted; else variable.Optimized = true;
} else if (head == "isblocked") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsBlocked")) variable.Value = ssIsBlocked; else variable.Optimized = true;
} else if (head == "blockeduntil") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BlockedUntil")) variable.Value = ssBlockedUntil; else variable.Optimized = true;
} else if (head == "lastlogindate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LastLoginDate")) variable.Value = ssLastLoginDate; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "updatedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedBy")) variable.Value = ssUpdatedBy; else variable.Optimized = true;
} else if (head == "updatedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedOn")) variable.Value = ssUpdatedOn; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdSupplierId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdUserId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdName)) {
return ChangedAttributes[3];
}
if (key.Equals(IdEmail)) {
return ChangedAttributes[4];
}
if (key.Equals(IdActivationEmailSentDate)) {
return ChangedAttributes[5];
}
if (key.Equals(IdIsActive)) {
return ChangedAttributes[6];
}
if (key.Equals(IdIsDeleted)) {
return ChangedAttributes[7];
}
if (key.Equals(IdIsBlocked)) {
return ChangedAttributes[8];
}
if (key.Equals(IdBlockedUntil)) {
return ChangedAttributes[9];
}
if (key.Equals(IdLastLoginDate)) {
return ChangedAttributes[10];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[11];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[12];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[13];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[14];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdSupplierId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdUserId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdName)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdEmail)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdActivationEmailSentDate)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdIsActive)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdIsDeleted)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdIsBlocked)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdBlockedUntil)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdLastLoginDate)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[14];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdSupplierId) {
return ssSupplierId;
}
if (key == IdUserId) {
return ssUserId;
}
if (key == IdName) {
return ssName;
}
if (key == IdEmail) {
return ssEmail;
}
if (key == IdActivationEmailSentDate) {
return ssActivationEmailSentDate;
}
if (key == IdIsActive) {
return ssIsActive;
}
if (key == IdIsDeleted) {
return ssIsDeleted;
}
if (key == IdIsBlocked) {
return ssIsBlocked;
}
if (key == IdBlockedUntil) {
return ssBlockedUntil;
}
if (key == IdLastLoginDate) {
return ssLastLoginDate;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdUpdatedBy) {
return ssUpdatedBy;
}
if (key == IdUpdatedOn) {
return ssUpdatedOn;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdSupplierId.Key.AsGuid) {
return ssSupplierId;
}
if (attributeKey == IdUserId.Key.AsGuid) {
return ssUserId;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdEmail.Key.AsGuid) {
return ssEmail;
}
if (attributeKey == IdActivationEmailSentDate.Key.AsGuid) {
return ssActivationEmailSentDate;
}
if (attributeKey == IdIsActive.Key.AsGuid) {
return ssIsActive;
}
if (attributeKey == IdIsDeleted.Key.AsGuid) {
return ssIsDeleted;
}
if (attributeKey == IdIsBlocked.Key.AsGuid) {
return ssIsBlocked;
}
if (attributeKey == IdBlockedUntil.Key.AsGuid) {
return ssBlockedUntil;
}
if (attributeKey == IdLastLoginDate.Key.AsGuid) {
return ssLastLoginDate;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdUpdatedBy.Key.AsGuid) {
return ssUpdatedBy;
}
if (attributeKey == IdUpdatedOn.Key.AsGuid) {
return ssUpdatedOn;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(15);
OptimizedAttributes = new BitArray(15);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssSupplierId = (long) other.AttributeGet(IdSupplierId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdSupplierId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdSupplierId);
ssUserId = (string) other.AttributeGet(IdUserId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdUserId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdUserId);
ssName = (string) other.AttributeGet(IdName);
ChangedAttributes[3] = other.ChangedAttributeGet(IdName);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdName);
ssEmail = (string) other.AttributeGet(IdEmail);
ChangedAttributes[4] = other.ChangedAttributeGet(IdEmail);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdEmail);
ssActivationEmailSentDate = (DateTime) other.AttributeGet(IdActivationEmailSentDate);
ChangedAttributes[5] = other.ChangedAttributeGet(IdActivationEmailSentDate);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdActivationEmailSentDate);
ssIsActive = (bool) other.AttributeGet(IdIsActive);
ChangedAttributes[6] = other.ChangedAttributeGet(IdIsActive);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdIsActive);
ssIsDeleted = (bool) other.AttributeGet(IdIsDeleted);
ChangedAttributes[7] = other.ChangedAttributeGet(IdIsDeleted);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdIsDeleted);
ssIsBlocked = (bool) other.AttributeGet(IdIsBlocked);
ChangedAttributes[8] = other.ChangedAttributeGet(IdIsBlocked);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdIsBlocked);
ssBlockedUntil = (DateTime) other.AttributeGet(IdBlockedUntil);
ChangedAttributes[9] = other.ChangedAttributeGet(IdBlockedUntil);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdBlockedUntil);
ssLastLoginDate = (DateTime) other.AttributeGet(IdLastLoginDate);
ChangedAttributes[10] = other.ChangedAttributeGet(IdLastLoginDate);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdLastLoginDate);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[11] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[12] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdCreatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[13] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdUpdatedBy);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[14] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdUpdatedOn);
}
} // EN_360367a38fba8439556dd1e5826e0428EntityRecord

/// <summary>
/// RecordList type <code>SupplierUserList</code> that represents a record list of
///  <code>SupplierUser</code>
/// </summary>
public partial class RL_89d8f1f04f59f7afe975fc4f6c956682 : GenericRecordList<EN_360367a38fba8439556dd1e5826e0428EntityRecord>, IEnumerable, IEnumerator {

protected override EN_360367a38fba8439556dd1e5826e0428EntityRecord GetElementDefaultValue() {
return new EN_360367a38fba8439556dd1e5826e0428EntityRecord();
}

public T[] ToArray<T>(Func<EN_360367a38fba8439556dd1e5826e0428EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_89d8f1f04f59f7afe975fc4f6c956682 recordList, Func<EN_360367a38fba8439556dd1e5826e0428EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_89d8f1f04f59f7afe975fc4f6c956682(EN_360367a38fba8439556dd1e5826e0428EntityRecord[] array) {
  RL_89d8f1f04f59f7afe975fc4f6c956682 result = new RL_89d8f1f04f59f7afe975fc4f6c956682();
result.InnerFromArray(array);
    return result;
}

public static RL_89d8f1f04f59f7afe975fc4f6c956682 ToList<T>(T[] array, Func <T, EN_360367a38fba8439556dd1e5826e0428EntityRecord> converter) {
  RL_89d8f1f04f59f7afe975fc4f6c956682 result = new RL_89d8f1f04f59f7afe975fc4f6c956682();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_89d8f1f04f59f7afe975fc4f6c956682 FromRestList<T>(RestList<T> restList, Func <T, EN_360367a38fba8439556dd1e5826e0428EntityRecord> converter) {
  RL_89d8f1f04f59f7afe975fc4f6c956682 result = new RL_89d8f1f04f59f7afe975fc4f6c956682();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_89d8f1f04f59f7afe975fc4f6c956682() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_360367a38fba8439556dd1e5826e0428EntityRecord> NewList() {
return new RL_89d8f1f04f59f7afe975fc4f6c956682();
}


} // RL_89d8f1f04f59f7afe975fc4f6c956682
}
