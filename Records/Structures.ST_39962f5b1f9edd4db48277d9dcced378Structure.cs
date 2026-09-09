namespace ssConectaProveedores {
/// <summary>
/// [Structure] InvoicesReport48_6Approval (lk8nT5tOUU6xaGbgAalv0A)
///  <code>ST_39962f5b1f9edd4db48277d9dcced378Structure</code> that represent
/// s <code>InvoicesReport48_6Approval</code> <p>Description: </p>
/// </summary>
// Name: InvoicesReport48_6Approval
public partial struct ST_39962f5b1f9edd4db48277d9dcced378Structure : ITypedRecord<ST_39962f5b1f9edd4db48277d9dcced378Structure> {
internal static readonly GlobalObjectKey IdApprovingUsers = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*z2vylPF_OkOyhlJ9c2C0VQ");
internal static readonly GlobalObjectKey IdInvoiceApprovalDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*PrSH0_adoU+DQ6CbuD2nLw");
internal static readonly GlobalObjectKey IdApprovalArea = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*oAkx8d0yA06wJZvozad2Aw");
internal static readonly GlobalObjectKey IdAccountingUser = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*WZbqB6C1iUChzKxspoMxng");

public string ssApprovingUsers;

public DateTime ssInvoiceApprovalDate;

public string ssApprovalArea;

public string ssAccountingUser;


public BitArray OptimizedAttributes;

public ST_39962f5b1f9edd4db48277d9dcced378Structure() {
OptimizedAttributes = null;
ssApprovingUsers = "";
ssInvoiceApprovalDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssApprovalArea = "";
ssAccountingUser = "";
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
ssApprovingUsers = r.ReadText(index++, "InvoicesReport48_6Approval.ApprovingUsers", "");
ssInvoiceApprovalDate = r.ReadDate(index++, "InvoicesReport48_6Approval.InvoiceApprovalDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssApprovalArea = r.ReadText(index++, "InvoicesReport48_6Approval.ApprovalArea", "");
ssAccountingUser = r.ReadText(index++, "InvoicesReport48_6Approval.AccountingUser", "");
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
public void ReadIM(ST_39962f5b1f9edd4db48277d9dcced378Structure r) {
this = r;
}


public static bool operator == (ST_39962f5b1f9edd4db48277d9dcced378Structure a, ST_39962f5b1f9edd4db48277d9dcced378Structure b) {
if (a.ssApprovingUsers != b.ssApprovingUsers) return false;
if (a.ssInvoiceApprovalDate != b.ssInvoiceApprovalDate) return false;
if (a.ssApprovalArea != b.ssApprovalArea) return false;
if (a.ssAccountingUser != b.ssAccountingUser) return false;
return true;
}

public static bool operator != (ST_39962f5b1f9edd4db48277d9dcced378Structure a, ST_39962f5b1f9edd4db48277d9dcced378Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_39962f5b1f9edd4db48277d9dcced378Structure)) return false;
return (this == (ST_39962f5b1f9edd4db48277d9dcced378Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssApprovingUsers.GetHashCode()
 ^ ssInvoiceApprovalDate.GetHashCode()
 ^ ssApprovalArea.GetHashCode()
 ^ ssAccountingUser.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_39962f5b1f9edd4db48277d9dcced378Structure Duplicate() {
ST_39962f5b1f9edd4db48277d9dcced378Structure t;
t.ssApprovingUsers = this.ssApprovingUsers;
t.ssInvoiceApprovalDate = this.ssInvoiceApprovalDate;
t.ssApprovalArea = this.ssApprovalArea;
t.ssAccountingUser = this.ssAccountingUser;
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
if (head == "approvingusers") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovingUsers")) variable.Value = ssApprovingUsers; else variable.Optimized = true;
} else if (head == "invoiceapprovaldate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApprovalDate")) variable.Value = ssInvoiceApprovalDate; else variable.Optimized = true;
} else if (head == "approvalarea") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalArea")) variable.Value = ssApprovalArea; else variable.Optimized = true;
} else if (head == "accountinguser") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingUser")) variable.Value = ssAccountingUser; else variable.Optimized = true;
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
if (key == IdApprovingUsers) {
return ssApprovingUsers;
}
if (key == IdInvoiceApprovalDate) {
return ssInvoiceApprovalDate;
}
if (key == IdApprovalArea) {
return ssApprovalArea;
}
if (key == IdAccountingUser) {
return ssAccountingUser;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApprovingUsers.Key.AsGuid) {
return ssApprovingUsers;
}
if (attributeKey == IdInvoiceApprovalDate.Key.AsGuid) {
return ssInvoiceApprovalDate;
}
if (attributeKey == IdApprovalArea.Key.AsGuid) {
return ssApprovalArea;
}
if (attributeKey == IdAccountingUser.Key.AsGuid) {
return ssAccountingUser;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssApprovingUsers = (string) other.AttributeGet(IdApprovingUsers);
ssInvoiceApprovalDate = (DateTime) other.AttributeGet(IdInvoiceApprovalDate);
ssApprovalArea = (string) other.AttributeGet(IdApprovalArea);
ssAccountingUser = (string) other.AttributeGet(IdAccountingUser);
}
} // ST_39962f5b1f9edd4db48277d9dcced378Structure
/// <summary>
/// RecordList type <code>InvoicesReport48_6ApprovalList</code> that represents a record list of
///  <code>InvoicesReport48_6Approval</code>
/// </summary>
public partial class RL_d6d86db79cbeb5fb80f818909fadd543 : GenericRecordList<ST_39962f5b1f9edd4db48277d9dcced378Structure>, IEnumerable, IEnumerator {

protected override ST_39962f5b1f9edd4db48277d9dcced378Structure GetElementDefaultValue() {
return new ST_39962f5b1f9edd4db48277d9dcced378Structure();
}

public T[] ToArray<T>(Func<ST_39962f5b1f9edd4db48277d9dcced378Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d6d86db79cbeb5fb80f818909fadd543 recordList, Func<ST_39962f5b1f9edd4db48277d9dcced378Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d6d86db79cbeb5fb80f818909fadd543(ST_39962f5b1f9edd4db48277d9dcced378Structure[] array) {
  RL_d6d86db79cbeb5fb80f818909fadd543 result = new RL_d6d86db79cbeb5fb80f818909fadd543();
result.InnerFromArray(array);
    return result;
}

public static RL_d6d86db79cbeb5fb80f818909fadd543 ToList<T>(T[] array, Func <T, ST_39962f5b1f9edd4db48277d9dcced378Structure> converter) {
  RL_d6d86db79cbeb5fb80f818909fadd543 result = new RL_d6d86db79cbeb5fb80f818909fadd543();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d6d86db79cbeb5fb80f818909fadd543 FromRestList<T>(RestList<T> restList, Func <T, ST_39962f5b1f9edd4db48277d9dcced378Structure> converter) {
  RL_d6d86db79cbeb5fb80f818909fadd543 result = new RL_d6d86db79cbeb5fb80f818909fadd543();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d6d86db79cbeb5fb80f818909fadd543() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_39962f5b1f9edd4db48277d9dcced378Structure> NewList() {
return new RL_d6d86db79cbeb5fb80f818909fadd543();
}


} // RL_d6d86db79cbeb5fb80f818909fadd543
}

