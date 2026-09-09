namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (avpZk9AZzkSwRQjmMIfurw)
///  <code>RC_bdad25a559cd2f146ec69d1aec036546</code> that represent
/// s <code>InvoiceApprovalInvoiceApprovalLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceApprovalInvoiceApprovalLevelRecord
public partial struct RC_bdad25a559cd2f146ec69d1aec036546 : ITypedRecord<RC_bdad25a559cd2f146ec69d1aec036546> {
internal static readonly GlobalObjectKey IdInvoiceApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6SDNjrWvFM3D8a6hpiYjdA");
internal static readonly GlobalObjectKey IdInvoiceApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OoBCpbF1VpO+gnn7Jp5V+w");

public EN_c2bd0675fed3aedb585c484c59155eddEntityRecord ssENInvoiceApproval;

public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord ssENInvoiceApprovalLevel;


public BitArray OptimizedAttributes;

public RC_bdad25a559cd2f146ec69d1aec036546() {
OptimizedAttributes = null;
ssENInvoiceApproval = new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord();
ssENInvoiceApprovalLevel = new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(10,false);
    all[1] = new BitArray(25,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceApproval.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENInvoiceApproval.OptimizedAttributes = value[0];
    ssENInvoiceApprovalLevel.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENInvoiceApproval.OptimizedAttributes;
    all[1] = ssENInvoiceApprovalLevel.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
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
public void ReadIM(RC_bdad25a559cd2f146ec69d1aec036546 r) {
this = r;
}


public static bool operator == (RC_bdad25a559cd2f146ec69d1aec036546 a, RC_bdad25a559cd2f146ec69d1aec036546 b) {
if (a.ssENInvoiceApproval != b.ssENInvoiceApproval) return false;
if (a.ssENInvoiceApprovalLevel != b.ssENInvoiceApprovalLevel) return false;
return true;
}

public static bool operator != (RC_bdad25a559cd2f146ec69d1aec036546 a, RC_bdad25a559cd2f146ec69d1aec036546 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_bdad25a559cd2f146ec69d1aec036546)) return false;
return (this == (RC_bdad25a559cd2f146ec69d1aec036546)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceApproval.GetHashCode()
 ^ ssENInvoiceApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceApproval.RecursiveReset();
ssENInvoiceApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceApproval.InternalRecursiveSave();
ssENInvoiceApprovalLevel.InternalRecursiveSave();
}


public RC_bdad25a559cd2f146ec69d1aec036546 Duplicate() {
RC_bdad25a559cd2f146ec69d1aec036546 t;
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
if (head == "invoiceapproval") {
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
if (key == IdInvoiceApproval) {
return ssENInvoiceApproval;
}
if (key == IdInvoiceApprovalLevel) {
return ssENInvoiceApprovalLevel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
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
ssENInvoiceApproval.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApproval));
ssENInvoiceApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApprovalLevel));
}
} // RC_bdad25a559cd2f146ec69d1aec036546
/// <summary>
/// RecordList type <code>InvoiceApprovalInvoiceApprovalLevelRecordList</code> that represents a record
///  list of <code>InvoiceApproval, InvoiceApprovalLevel</code>
/// </summary>
public partial class RL_6dc54c806e79e3021c958eb2cb6d90be : GenericRecordList<RC_bdad25a559cd2f146ec69d1aec036546>, IEnumerable, IEnumerator {

protected override RC_bdad25a559cd2f146ec69d1aec036546 GetElementDefaultValue() {
return new RC_bdad25a559cd2f146ec69d1aec036546();
}

public T[] ToArray<T>(Func<RC_bdad25a559cd2f146ec69d1aec036546, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6dc54c806e79e3021c958eb2cb6d90be recordList, Func<RC_bdad25a559cd2f146ec69d1aec036546, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6dc54c806e79e3021c958eb2cb6d90be(RC_bdad25a559cd2f146ec69d1aec036546[] array) {
  RL_6dc54c806e79e3021c958eb2cb6d90be result = new RL_6dc54c806e79e3021c958eb2cb6d90be();
result.InnerFromArray(array);
    return result;
}

public static RL_6dc54c806e79e3021c958eb2cb6d90be ToList<T>(T[] array, Func <T, RC_bdad25a559cd2f146ec69d1aec036546> converter) {
  RL_6dc54c806e79e3021c958eb2cb6d90be result = new RL_6dc54c806e79e3021c958eb2cb6d90be();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6dc54c806e79e3021c958eb2cb6d90be FromRestList<T>(RestList<T> restList, Func <T, RC_bdad25a559cd2f146ec69d1aec036546> converter) {
  RL_6dc54c806e79e3021c958eb2cb6d90be result = new RL_6dc54c806e79e3021c958eb2cb6d90be();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6dc54c806e79e3021c958eb2cb6d90be() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(10,false);
def[1] = new BitArray(25,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_bdad25a559cd2f146ec69d1aec036546> NewList() {
return new RL_6dc54c806e79e3021c958eb2cb6d90be();
}


} // RL_6dc54c806e79e3021c958eb2cb6d90be
}

