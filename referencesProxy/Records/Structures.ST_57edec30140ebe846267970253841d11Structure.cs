namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] TI_RETENCIONES_In3 (SV+Rfvvb_Uyq6YhJhBVBAQ)
///  <code>ST_57edec30140ebe846267970253841d11Structure</code> that represent
/// s <code>TI_RETENCIONES_In3</code> <p>Description: </p>
/// </summary>
// Name: TI_RETENCIONES_In3
public partial struct ST_57edec30140ebe846267970253841d11Structure : ITypedRecord<ST_57edec30140ebe846267970253841d11Structure> {
internal static readonly GlobalObjectKey IdWITHT = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*hBBy8zDbtEG0Yep2hH72Xw");
internal static readonly GlobalObjectKey IdWT_WITHCD = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*zllLMyWtKkuedVFQmbQTeg");
internal static readonly GlobalObjectKey IdWT_SUBJCT = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*V8WjSngGtEyX6gPnPHXEdw");

public string ssWITHT;

public string ssWT_WITHCD;

public string ssWT_SUBJCT;


public BitArray OptimizedAttributes;

public ST_57edec30140ebe846267970253841d11Structure() {
OptimizedAttributes = null;
ssWITHT = "";
ssWT_WITHCD = "";
ssWT_SUBJCT = "";
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
ssWITHT = r.ReadText(index++, "TI_RETENCIONES_In3.WITHT", "");
ssWT_WITHCD = r.ReadText(index++, "TI_RETENCIONES_In3.WT_WITHCD", "");
ssWT_SUBJCT = r.ReadText(index++, "TI_RETENCIONES_In3.WT_SUBJCT", "");
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
public void ReadIM(ST_57edec30140ebe846267970253841d11Structure r) {
this = r;
}


public static bool operator == (ST_57edec30140ebe846267970253841d11Structure a, ST_57edec30140ebe846267970253841d11Structure b) {
if (a.ssWITHT != b.ssWITHT) return false;
if (a.ssWT_WITHCD != b.ssWT_WITHCD) return false;
if (a.ssWT_SUBJCT != b.ssWT_SUBJCT) return false;
return true;
}

public static bool operator != (ST_57edec30140ebe846267970253841d11Structure a, ST_57edec30140ebe846267970253841d11Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_57edec30140ebe846267970253841d11Structure)) return false;
return (this == (ST_57edec30140ebe846267970253841d11Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssWITHT.GetHashCode()
 ^ ssWT_WITHCD.GetHashCode()
 ^ ssWT_SUBJCT.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_57edec30140ebe846267970253841d11Structure Duplicate() {
ST_57edec30140ebe846267970253841d11Structure t;
t.ssWITHT = this.ssWITHT;
t.ssWT_WITHCD = this.ssWT_WITHCD;
t.ssWT_SUBJCT = this.ssWT_SUBJCT;
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
if (head == "witht") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WITHT")) variable.Value = ssWITHT; else variable.Optimized = true;
} else if (head == "wt_withcd") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WT_WITHCD")) variable.Value = ssWT_WITHCD; else variable.Optimized = true;
} else if (head == "wt_subjct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WT_SUBJCT")) variable.Value = ssWT_SUBJCT; else variable.Optimized = true;
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
if (key == IdWITHT) {
return ssWITHT;
}
if (key == IdWT_WITHCD) {
return ssWT_WITHCD;
}
if (key == IdWT_SUBJCT) {
return ssWT_SUBJCT;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdWITHT.Key.AsGuid) {
return ssWITHT;
}
if (attributeKey == IdWT_WITHCD.Key.AsGuid) {
return ssWT_WITHCD;
}
if (attributeKey == IdWT_SUBJCT.Key.AsGuid) {
return ssWT_SUBJCT;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssWITHT = (string) other.AttributeGet(IdWITHT);
ssWT_WITHCD = (string) other.AttributeGet(IdWT_WITHCD);
ssWT_SUBJCT = (string) other.AttributeGet(IdWT_SUBJCT);
}
} // ST_57edec30140ebe846267970253841d11Structure
/// <summary>
/// RecordList type <code>TI_RETENCIONES_In3List</code> that represents a record list of
///  <code>TI_RETENCIONES_In3</code>
/// </summary>
public partial class RL_725bda958021cd78431a036d1def2d7e : GenericRecordList<ST_57edec30140ebe846267970253841d11Structure>, IEnumerable, IEnumerator {

protected override ST_57edec30140ebe846267970253841d11Structure GetElementDefaultValue() {
return new ST_57edec30140ebe846267970253841d11Structure();
}

public T[] ToArray<T>(Func<ST_57edec30140ebe846267970253841d11Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_725bda958021cd78431a036d1def2d7e recordList, Func<ST_57edec30140ebe846267970253841d11Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_725bda958021cd78431a036d1def2d7e(ST_57edec30140ebe846267970253841d11Structure[] array) {
  RL_725bda958021cd78431a036d1def2d7e result = new RL_725bda958021cd78431a036d1def2d7e();
result.InnerFromArray(array);
    return result;
}

public static RL_725bda958021cd78431a036d1def2d7e ToList<T>(T[] array, Func <T, ST_57edec30140ebe846267970253841d11Structure> converter) {
  RL_725bda958021cd78431a036d1def2d7e result = new RL_725bda958021cd78431a036d1def2d7e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_725bda958021cd78431a036d1def2d7e FromRestList<T>(RestList<T> restList, Func <T, ST_57edec30140ebe846267970253841d11Structure> converter) {
  RL_725bda958021cd78431a036d1def2d7e result = new RL_725bda958021cd78431a036d1def2d7e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_725bda958021cd78431a036d1def2d7e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_57edec30140ebe846267970253841d11Structure> NewList() {
return new RL_725bda958021cd78431a036d1def2d7e();
}


} // RL_725bda958021cd78431a036d1def2d7e
}

