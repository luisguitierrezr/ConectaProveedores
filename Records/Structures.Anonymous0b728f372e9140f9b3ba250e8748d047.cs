namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (N49yC5Eu+UCzuiUOh0jQRw)
///  <code>RC_0c929027c696b201a1aceb2f23c1d74d</code> that represent
/// s <code>UserInvoiceApprovalInvoiceApprovalLevelApplicationRoleRecord</code> <p>Description: </p>
/// </summary>
// Name: UserInvoiceApprovalInvoiceApprovalLevelApplicationRoleRecord
public partial struct RC_0c929027c696b201a1aceb2f23c1d74d : ITypedRecord<RC_0c929027c696b201a1aceb2f23c1d74d> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdInvoiceApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6SDNjrWvFM3D8a6hpiYjdA");
internal static readonly GlobalObjectKey IdInvoiceApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OoBCpbF1VpO+gnn7Jp5V+w");
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Q0fszuVdwmNpC2BezKaalA");

public ENUserEntityRecord ssENUser;

public EN_c2bd0675fed3aedb585c484c59155eddEntityRecord ssENInvoiceApproval;

public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord ssENInvoiceApprovalLevel;

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ssENApplicationRole;


public BitArray OptimizedAttributes;

public RC_0c929027c696b201a1aceb2f23c1d74d() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENInvoiceApproval = new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord();
ssENInvoiceApprovalLevel = new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord();
ssENApplicationRole = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(10,false);
    all[2] = new BitArray(25,false);
    all[3] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceApproval.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENInvoiceApproval.OptimizedAttributes = value[1];
    ssENInvoiceApprovalLevel.OptimizedAttributes = value[2];
    ssENApplicationRole.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENInvoiceApproval.OptimizedAttributes;
    all[2] = ssENInvoiceApprovalLevel.OptimizedAttributes;
    all[3] = ssENApplicationRole.OptimizedAttributes;
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
ssENApplicationRole.Read( r, ref index);
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
public void ReadIM(RC_0c929027c696b201a1aceb2f23c1d74d r) {
this = r;
}


public static bool operator == (RC_0c929027c696b201a1aceb2f23c1d74d a, RC_0c929027c696b201a1aceb2f23c1d74d b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENInvoiceApproval != b.ssENInvoiceApproval) return false;
if (a.ssENInvoiceApprovalLevel != b.ssENInvoiceApprovalLevel) return false;
if (a.ssENApplicationRole != b.ssENApplicationRole) return false;
return true;
}

public static bool operator != (RC_0c929027c696b201a1aceb2f23c1d74d a, RC_0c929027c696b201a1aceb2f23c1d74d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0c929027c696b201a1aceb2f23c1d74d)) return false;
return (this == (RC_0c929027c696b201a1aceb2f23c1d74d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENInvoiceApproval.GetHashCode()
 ^ ssENInvoiceApprovalLevel.GetHashCode()
 ^ ssENApplicationRole.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENInvoiceApproval.RecursiveReset();
ssENInvoiceApprovalLevel.RecursiveReset();
ssENApplicationRole.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENInvoiceApproval.InternalRecursiveSave();
ssENInvoiceApprovalLevel.InternalRecursiveSave();
ssENApplicationRole.InternalRecursiveSave();
}


public RC_0c929027c696b201a1aceb2f23c1d74d Duplicate() {
RC_0c929027c696b201a1aceb2f23c1d74d t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENInvoiceApproval = (EN_c2bd0675fed3aedb585c484c59155eddEntityRecord)this.ssENInvoiceApproval.Duplicate();
t.ssENInvoiceApprovalLevel = (EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord)this.ssENInvoiceApprovalLevel.Duplicate();
t.ssENApplicationRole = (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord)this.ssENApplicationRole.Duplicate();
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
} else if (head == "applicationrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRole")) variable.Value = ssENApplicationRole; else variable.Optimized = true;
variable.SetFieldName("applicationrole");
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
if (key == IdApplicationRole) {
return ssENApplicationRole;
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
if (attributeKey == IdApplicationRole.Key.AsGuid) {
return ssENApplicationRole;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENInvoiceApproval.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApproval));
ssENInvoiceApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApprovalLevel));
ssENApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdApplicationRole));
}
} // RC_0c929027c696b201a1aceb2f23c1d74d
/// <summary>
/// RecordList type <code>UserInvoiceApprovalInvoiceApprovalLevelApplicationRoleRecordList</code> that
///  represents a record list of <code>User, InvoiceApproval, InvoiceApprovalLevel
/// , ApplicationRole</code>
/// </summary>
public partial class RL_bed92cf49c584b7d4ab2b8923c043fa1 : GenericRecordList<RC_0c929027c696b201a1aceb2f23c1d74d>, IEnumerable, IEnumerator {

protected override RC_0c929027c696b201a1aceb2f23c1d74d GetElementDefaultValue() {
return new RC_0c929027c696b201a1aceb2f23c1d74d();
}

public T[] ToArray<T>(Func<RC_0c929027c696b201a1aceb2f23c1d74d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_bed92cf49c584b7d4ab2b8923c043fa1 recordList, Func<RC_0c929027c696b201a1aceb2f23c1d74d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_bed92cf49c584b7d4ab2b8923c043fa1(RC_0c929027c696b201a1aceb2f23c1d74d[] array) {
  RL_bed92cf49c584b7d4ab2b8923c043fa1 result = new RL_bed92cf49c584b7d4ab2b8923c043fa1();
result.InnerFromArray(array);
    return result;
}

public static RL_bed92cf49c584b7d4ab2b8923c043fa1 ToList<T>(T[] array, Func <T, RC_0c929027c696b201a1aceb2f23c1d74d> converter) {
  RL_bed92cf49c584b7d4ab2b8923c043fa1 result = new RL_bed92cf49c584b7d4ab2b8923c043fa1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_bed92cf49c584b7d4ab2b8923c043fa1 FromRestList<T>(RestList<T> restList, Func <T, RC_0c929027c696b201a1aceb2f23c1d74d> converter) {
  RL_bed92cf49c584b7d4ab2b8923c043fa1 result = new RL_bed92cf49c584b7d4ab2b8923c043fa1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_bed92cf49c584b7d4ab2b8923c043fa1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(5,false);
def[1] = new BitArray(10,false);
def[2] = new BitArray(25,false);
def[3] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_0c929027c696b201a1aceb2f23c1d74d> NewList() {
return new RL_bed92cf49c584b7d4ab2b8923c043fa1();
}


} // RL_bed92cf49c584b7d4ab2b8923c043fa1
}

