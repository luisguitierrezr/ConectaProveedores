namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (gSuVjsPln0GALIWMnuSdzQ)
///  <code>RC_85f15a383e9651f9f34f899ceee2be30</code> that represent
/// s <code>UserInvoiceApprovalInvoiceApprovalLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: UserInvoiceApprovalInvoiceApprovalLevelRecord
public partial struct RC_85f15a383e9651f9f34f899ceee2be30 : ITypedRecord<RC_85f15a383e9651f9f34f899ceee2be30> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdInvoiceApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6SDNjrWvFM3D8a6hpiYjdA");
internal static readonly GlobalObjectKey IdInvoiceApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OoBCpbF1VpO+gnn7Jp5V+w");

public ENUserEntityRecord ssENUser;

public EN_c2bd0675fed3aedb585c484c59155eddEntityRecord ssENInvoiceApproval;

public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord ssENInvoiceApprovalLevel;


public BitArray OptimizedAttributes;

public RC_85f15a383e9651f9f34f899ceee2be30() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENInvoiceApproval = new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord();
ssENInvoiceApprovalLevel = new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(10,false);
    all[2] = new BitArray(25,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceApproval.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENInvoiceApproval.OptimizedAttributes = value[1];
    ssENInvoiceApprovalLevel.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENInvoiceApproval.OptimizedAttributes;
    all[2] = ssENInvoiceApprovalLevel.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUser.Read( r, ref index);
ssENInvoiceApproval.Read( r, ref index);
ssENInvoiceApprovalLevel.Read( r, ref index);
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
public void ReadIM(RC_85f15a383e9651f9f34f899ceee2be30 r) {
this = r;
}


public static bool operator == (RC_85f15a383e9651f9f34f899ceee2be30 a, RC_85f15a383e9651f9f34f899ceee2be30 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENInvoiceApproval != b.ssENInvoiceApproval) return false;
if (a.ssENInvoiceApprovalLevel != b.ssENInvoiceApprovalLevel) return false;
return true;
}

public static bool operator != (RC_85f15a383e9651f9f34f899ceee2be30 a, RC_85f15a383e9651f9f34f899ceee2be30 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_85f15a383e9651f9f34f899ceee2be30)) return false;
return (this == (RC_85f15a383e9651f9f34f899ceee2be30)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENInvoiceApproval.GetHashCode()
 ^ ssENInvoiceApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENInvoiceApproval.RecursiveReset();
ssENInvoiceApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENInvoiceApproval.InternalRecursiveSave();
ssENInvoiceApprovalLevel.InternalRecursiveSave();
}


public RC_85f15a383e9651f9f34f899ceee2be30 Duplicate() {
RC_85f15a383e9651f9f34f899ceee2be30 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENInvoiceApproval = (EN_c2bd0675fed3aedb585c484c59155eddEntityRecord)this.ssENInvoiceApproval.Duplicate();
t.ssENInvoiceApprovalLevel = (EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord)this.ssENInvoiceApprovalLevel.Duplicate();
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
if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
} else if (head == "invoiceapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApproval")) variable.Value = ssENInvoiceApproval; else variable.Optimized = true;
variable.SetFieldName("invoiceapproval");
} else if (head == "invoiceapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApprovalLevel")) variable.Value = ssENInvoiceApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("invoiceapprovallevel");
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
if (key == IdUser) {
return ssENUser;
}
if (key == IdInvoiceApproval) {
return ssENInvoiceApproval;
}
if (key == IdInvoiceApprovalLevel) {
return ssENInvoiceApprovalLevel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdInvoiceApproval.Key.AsGuid) {
return ssENInvoiceApproval;
}
if (attributeKey == IdInvoiceApprovalLevel.Key.AsGuid) {
return ssENInvoiceApprovalLevel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENInvoiceApproval.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApproval));
ssENInvoiceApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApprovalLevel));
}
} // RC_85f15a383e9651f9f34f899ceee2be30
/// <summary>
/// RecordList type <code>UserInvoiceApprovalInvoiceApprovalLevelRecordList</code> that represents a
///  record list of <code>User, InvoiceApproval, InvoiceApprovalLevel</code>
/// </summary>
public partial class RL_540f5613fbde7a506fffd29a691298e6 : GenericRecordList<RC_85f15a383e9651f9f34f899ceee2be30>, IEnumerable, IEnumerator {

protected override RC_85f15a383e9651f9f34f899ceee2be30 GetElementDefaultValue() {
return new RC_85f15a383e9651f9f34f899ceee2be30();
}

public T[] ToArray<T>(Func<RC_85f15a383e9651f9f34f899ceee2be30, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_540f5613fbde7a506fffd29a691298e6 recordList, Func<RC_85f15a383e9651f9f34f899ceee2be30, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_540f5613fbde7a506fffd29a691298e6(RC_85f15a383e9651f9f34f899ceee2be30[] array) {
  RL_540f5613fbde7a506fffd29a691298e6 result = new RL_540f5613fbde7a506fffd29a691298e6();
result.InnerFromArray(array);
    return result;
}

public static RL_540f5613fbde7a506fffd29a691298e6 ToList<T>(T[] array, Func <T, RC_85f15a383e9651f9f34f899ceee2be30> converter) {
  RL_540f5613fbde7a506fffd29a691298e6 result = new RL_540f5613fbde7a506fffd29a691298e6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_540f5613fbde7a506fffd29a691298e6 FromRestList<T>(RestList<T> restList, Func <T, RC_85f15a383e9651f9f34f899ceee2be30> converter) {
  RL_540f5613fbde7a506fffd29a691298e6 result = new RL_540f5613fbde7a506fffd29a691298e6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_540f5613fbde7a506fffd29a691298e6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(5,false);
def[1] = new BitArray(10,false);
def[2] = new BitArray(25,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_85f15a383e9651f9f34f899ceee2be30> NewList() {
return new RL_540f5613fbde7a506fffd29a691298e6();
}


} // RL_540f5613fbde7a506fffd29a691298e6
}

