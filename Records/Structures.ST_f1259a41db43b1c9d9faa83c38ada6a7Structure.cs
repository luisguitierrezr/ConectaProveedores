namespace ssConectaProveedores {
/// <summary>
/// [Structure] InvoiceCommentSA (W78GoHwyAECRieGS2L7H_g)
///  <code>ST_f1259a41db43b1c9d9faa83c38ada6a7Structure</code> that represent
/// s <code>InvoiceCommentSA</code> <p>Description: </p>
/// </summary>
// Name: InvoiceCommentSA
public partial struct ST_f1259a41db43b1c9d9faa83c38ada6a7Structure : ITypedRecord<ST_f1259a41db43b1c9d9faa83c38ada6a7Structure> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*RRbYqS5wAEGlzxNXgo_twg");
internal static readonly GlobalObjectKey IdInvoiceId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*kzupjqwSr0inLhWxQLCWVQ");
internal static readonly GlobalObjectKey IdInvoiceApprovalLevelId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*zh_hgTfnu0ScbOjywPUp0A");
internal static readonly GlobalObjectKey IdApplicationRoleId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vNdfKHYc80+I3benm921rQ");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*KKUDfzIKQkq7DaakM0QUew");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*IFgs+JvdcEC0VKpujEEn6g");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*wed3ycKcgkeykEpANhg9Vw");
internal static readonly GlobalObjectKey IdIsPublic = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*U1oLpRCCYEuOXat9n9t8bw");

public long ssId;

public long ssInvoiceId;

public long ssInvoiceApprovalLevelId;

public long ssApplicationRoleId;

public DateTime ssCreatedOn;

public string ssCreatedBy;

public string ssMessage;

public bool ssIsPublic;


public BitArray OptimizedAttributes;

public ST_f1259a41db43b1c9d9faa83c38ada6a7Structure() {
OptimizedAttributes = null;
ssId = 0L;
ssInvoiceId = 0L;
ssInvoiceApprovalLevelId = 0L;
ssApplicationRoleId = 0L;
ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssCreatedBy = "";
ssMessage = "";
ssIsPublic = false;
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
ssId = r.ReadLongInteger(index++, "InvoiceCommentSA.Id", 0L);
ssInvoiceId = r.ReadEntityReferenceLongInteger(index++, "InvoiceCommentSA.InvoiceId", 0L);
ssInvoiceApprovalLevelId = r.ReadEntityReferenceLongInteger(index++, "InvoiceCommentSA.InvoiceApprovalLevelId", 0L);
ssApplicationRoleId = r.ReadEntityReferenceLongInteger(index++, "InvoiceCommentSA.ApplicationRoleId", 0L);
ssCreatedOn = r.ReadDateTime(index++, "InvoiceCommentSA.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "InvoiceCommentSA.CreatedBy", "");
ssMessage = r.ReadText(index++, "InvoiceCommentSA.Message", "");
ssIsPublic = r.ReadBoolean(index++, "InvoiceCommentSA.IsPublic", false);
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
public void ReadIM(ST_f1259a41db43b1c9d9faa83c38ada6a7Structure r) {
this = r;
}


public static bool operator == (ST_f1259a41db43b1c9d9faa83c38ada6a7Structure a, ST_f1259a41db43b1c9d9faa83c38ada6a7Structure b) {
if (a.ssId != b.ssId) return false;
if (a.ssInvoiceId != b.ssInvoiceId) return false;
if (a.ssInvoiceApprovalLevelId != b.ssInvoiceApprovalLevelId) return false;
if (a.ssApplicationRoleId != b.ssApplicationRoleId) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssMessage != b.ssMessage) return false;
if (a.ssIsPublic != b.ssIsPublic) return false;
return true;
}

public static bool operator != (ST_f1259a41db43b1c9d9faa83c38ada6a7Structure a, ST_f1259a41db43b1c9d9faa83c38ada6a7Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_f1259a41db43b1c9d9faa83c38ada6a7Structure)) return false;
return (this == (ST_f1259a41db43b1c9d9faa83c38ada6a7Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssInvoiceId.GetHashCode()
 ^ ssInvoiceApprovalLevelId.GetHashCode()
 ^ ssApplicationRoleId.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssMessage.GetHashCode()
 ^ ssIsPublic.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_f1259a41db43b1c9d9faa83c38ada6a7Structure Duplicate() {
ST_f1259a41db43b1c9d9faa83c38ada6a7Structure t;
t.ssId = this.ssId;
t.ssInvoiceId = this.ssInvoiceId;
t.ssInvoiceApprovalLevelId = this.ssInvoiceApprovalLevelId;
t.ssApplicationRoleId = this.ssApplicationRoleId;
t.ssCreatedOn = this.ssCreatedOn;
t.ssCreatedBy = this.ssCreatedBy;
t.ssMessage = this.ssMessage;
t.ssIsPublic = this.ssIsPublic;
t.OptimizedAttributes = null;
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
} else if (head == "invoiceid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceId")) variable.Value = ssInvoiceId; else variable.Optimized = true;
} else if (head == "invoiceapprovallevelid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApprovalLevelId")) variable.Value = ssInvoiceApprovalLevelId; else variable.Optimized = true;
} else if (head == "applicationroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRoleId")) variable.Value = ssApplicationRoleId; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Message")) variable.Value = ssMessage; else variable.Optimized = true;
} else if (head == "ispublic") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsPublic")) variable.Value = ssIsPublic; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdInvoiceId) {
return ssInvoiceId;
}
if (key == IdInvoiceApprovalLevelId) {
return ssInvoiceApprovalLevelId;
}
if (key == IdApplicationRoleId) {
return ssApplicationRoleId;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdMessage) {
return ssMessage;
}
if (key == IdIsPublic) {
return ssIsPublic;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdInvoiceId.Key.AsGuid) {
return ssInvoiceId;
}
if (attributeKey == IdInvoiceApprovalLevelId.Key.AsGuid) {
return ssInvoiceApprovalLevelId;
}
if (attributeKey == IdApplicationRoleId.Key.AsGuid) {
return ssApplicationRoleId;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdMessage.Key.AsGuid) {
return ssMessage;
}
if (attributeKey == IdIsPublic.Key.AsGuid) {
return ssIsPublic;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ssInvoiceId = (long) other.AttributeGet(IdInvoiceId);
ssInvoiceApprovalLevelId = (long) other.AttributeGet(IdInvoiceApprovalLevelId);
ssApplicationRoleId = (long) other.AttributeGet(IdApplicationRoleId);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ssMessage = (string) other.AttributeGet(IdMessage);
ssIsPublic = (bool) other.AttributeGet(IdIsPublic);
}
} // ST_f1259a41db43b1c9d9faa83c38ada6a7Structure
/// <summary>
/// RecordList type <code>InvoiceCommentSAList</code> that represents a record list of
///  <code>InvoiceCommentSA</code>
/// </summary>
public partial class RL_926d85ed4cb2402ba9b1f6d39836fd78 : GenericRecordList<ST_f1259a41db43b1c9d9faa83c38ada6a7Structure>, IEnumerable, IEnumerator {

protected override ST_f1259a41db43b1c9d9faa83c38ada6a7Structure GetElementDefaultValue() {
return new ST_f1259a41db43b1c9d9faa83c38ada6a7Structure();
}

public T[] ToArray<T>(Func<ST_f1259a41db43b1c9d9faa83c38ada6a7Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_926d85ed4cb2402ba9b1f6d39836fd78 recordList, Func<ST_f1259a41db43b1c9d9faa83c38ada6a7Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_926d85ed4cb2402ba9b1f6d39836fd78(ST_f1259a41db43b1c9d9faa83c38ada6a7Structure[] array) {
  RL_926d85ed4cb2402ba9b1f6d39836fd78 result = new RL_926d85ed4cb2402ba9b1f6d39836fd78();
result.InnerFromArray(array);
    return result;
}

public static RL_926d85ed4cb2402ba9b1f6d39836fd78 ToList<T>(T[] array, Func <T, ST_f1259a41db43b1c9d9faa83c38ada6a7Structure> converter) {
  RL_926d85ed4cb2402ba9b1f6d39836fd78 result = new RL_926d85ed4cb2402ba9b1f6d39836fd78();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_926d85ed4cb2402ba9b1f6d39836fd78 FromRestList<T>(RestList<T> restList, Func <T, ST_f1259a41db43b1c9d9faa83c38ada6a7Structure> converter) {
  RL_926d85ed4cb2402ba9b1f6d39836fd78 result = new RL_926d85ed4cb2402ba9b1f6d39836fd78();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_926d85ed4cb2402ba9b1f6d39836fd78() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_f1259a41db43b1c9d9faa83c38ada6a7Structure> NewList() {
return new RL_926d85ed4cb2402ba9b1f6d39836fd78();
}


} // RL_926d85ed4cb2402ba9b1f6d39836fd78
}

