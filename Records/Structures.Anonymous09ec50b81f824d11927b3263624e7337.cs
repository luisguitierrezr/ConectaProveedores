namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (uFDsCYIfEU2SezJjYk5zNw)
///  <code>RC_06974d55bca345bb983c839ad25aa487</code> that represent
/// s <code>ApprovalProcessLevelEntraRoleRecord</code> <p>Description: </p>
/// </summary>
// Name: ApprovalProcessLevelEntraRoleRecord
public partial struct RC_06974d55bca345bb983c839ad25aa487 : ITypedRecord<RC_06974d55bca345bb983c839ad25aa487> {
internal static readonly GlobalObjectKey IdApprovalProcessLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xC_Afjv04bYAUGRMjBrjGw");
internal static readonly GlobalObjectKey IdEntraRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_1HoOmKLtNP_gEHeeBzkfQ");

public EN_1d28318723f39133c60733b3cce8955eEntityRecord ssENApprovalProcessLevel;

public EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord ssENEntraRole;


public BitArray OptimizedAttributes;

public RC_06974d55bca345bb983c839ad25aa487() {
OptimizedAttributes = null;
ssENApprovalProcessLevel = new EN_1d28318723f39133c60733b3cce8955eEntityRecord();
ssENEntraRole = new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(26,false);
    all[1] = new BitArray(6,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENApprovalProcessLevel.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENEntraRole.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENApprovalProcessLevel.OptimizedAttributes = value[0];
    ssENEntraRole.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENApprovalProcessLevel.OptimizedAttributes;
    all[1] = ssENEntraRole.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENApprovalProcessLevel.Read( r, ref index);
ssENEntraRole.Read( r, ref index);
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
public void ReadIM(RC_06974d55bca345bb983c839ad25aa487 r) {
this = r;
}


public static bool operator == (RC_06974d55bca345bb983c839ad25aa487 a, RC_06974d55bca345bb983c839ad25aa487 b) {
if (a.ssENApprovalProcessLevel != b.ssENApprovalProcessLevel) return false;
if (a.ssENEntraRole != b.ssENEntraRole) return false;
return true;
}

public static bool operator != (RC_06974d55bca345bb983c839ad25aa487 a, RC_06974d55bca345bb983c839ad25aa487 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_06974d55bca345bb983c839ad25aa487)) return false;
return (this == (RC_06974d55bca345bb983c839ad25aa487)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENApprovalProcessLevel.GetHashCode()
 ^ ssENEntraRole.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENApprovalProcessLevel.RecursiveReset();
ssENEntraRole.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENApprovalProcessLevel.InternalRecursiveSave();
ssENEntraRole.InternalRecursiveSave();
}


public RC_06974d55bca345bb983c839ad25aa487 Duplicate() {
RC_06974d55bca345bb983c839ad25aa487 t;
t.ssENApprovalProcessLevel = (EN_1d28318723f39133c60733b3cce8955eEntityRecord)this.ssENApprovalProcessLevel.Duplicate();
t.ssENEntraRole = (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord)this.ssENEntraRole.Duplicate();
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
if (head == "approvalprocesslevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalProcessLevel")) variable.Value = ssENApprovalProcessLevel; else variable.Optimized = true;
variable.SetFieldName("approvalprocesslevel");
} else if (head == "entrarole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRole")) variable.Value = ssENEntraRole; else variable.Optimized = true;
variable.SetFieldName("entrarole");
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
if (key == IdApprovalProcessLevel) {
return ssENApprovalProcessLevel;
}
if (key == IdEntraRole) {
return ssENEntraRole;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApprovalProcessLevel.Key.AsGuid) {
return ssENApprovalProcessLevel;
}
if (attributeKey == IdEntraRole.Key.AsGuid) {
return ssENEntraRole;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENApprovalProcessLevel.FillFromOther((IRecord) other.AttributeGet(IdApprovalProcessLevel));
ssENEntraRole.FillFromOther((IRecord) other.AttributeGet(IdEntraRole));
}
} // RC_06974d55bca345bb983c839ad25aa487
/// <summary>
/// RecordList type <code>ApprovalProcessLevelEntraRoleRecordList</code> that represents a record list
///  of <code>ApprovalProcessLevel, EntraRole</code>
/// </summary>
public partial class RL_ae429f8c6a2bb90441c9fdf2cffe0a0b : GenericRecordList<RC_06974d55bca345bb983c839ad25aa487>, IEnumerable, IEnumerator {

protected override RC_06974d55bca345bb983c839ad25aa487 GetElementDefaultValue() {
return new RC_06974d55bca345bb983c839ad25aa487();
}

public T[] ToArray<T>(Func<RC_06974d55bca345bb983c839ad25aa487, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ae429f8c6a2bb90441c9fdf2cffe0a0b recordList, Func<RC_06974d55bca345bb983c839ad25aa487, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ae429f8c6a2bb90441c9fdf2cffe0a0b(RC_06974d55bca345bb983c839ad25aa487[] array) {
  RL_ae429f8c6a2bb90441c9fdf2cffe0a0b result = new RL_ae429f8c6a2bb90441c9fdf2cffe0a0b();
result.InnerFromArray(array);
    return result;
}

public static RL_ae429f8c6a2bb90441c9fdf2cffe0a0b ToList<T>(T[] array, Func <T, RC_06974d55bca345bb983c839ad25aa487> converter) {
  RL_ae429f8c6a2bb90441c9fdf2cffe0a0b result = new RL_ae429f8c6a2bb90441c9fdf2cffe0a0b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ae429f8c6a2bb90441c9fdf2cffe0a0b FromRestList<T>(RestList<T> restList, Func <T, RC_06974d55bca345bb983c839ad25aa487> converter) {
  RL_ae429f8c6a2bb90441c9fdf2cffe0a0b result = new RL_ae429f8c6a2bb90441c9fdf2cffe0a0b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ae429f8c6a2bb90441c9fdf2cffe0a0b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(26,false);
def[1] = new BitArray(6,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_06974d55bca345bb983c839ad25aa487> NewList() {
return new RL_ae429f8c6a2bb90441c9fdf2cffe0a0b();
}


} // RL_ae429f8c6a2bb90441c9fdf2cffe0a0b
}

