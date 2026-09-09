namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] TI_WXD_Out (MlDJt3uf30ekvwS7XJG49A)
///  <code>ST_646bfb521d5f3e3e304163b436da5220Structure</code> that represents <code>TI_WXD_Out</code
/// > <p>Description: </p>
/// </summary>
// Name: TI_WXD_Out
public partial struct ST_646bfb521d5f3e3e304163b436da5220Structure : ITypedRecord<ST_646bfb521d5f3e3e304163b436da5220Structure> {
internal static readonly GlobalObjectKey IdSPLIT_KEY = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*iDkOyuOMK0OKxZJhCqsm4g");
internal static readonly GlobalObjectKey IdWI_TAX_TYPE = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*XS2BbfjKFEuREY4MqTXQPg");
internal static readonly GlobalObjectKey IdWI_TAX_CODE = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*Npq8W8fQi0WtB6IGdJkiGQ");
internal static readonly GlobalObjectKey IdWI_TAX_BASE = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*WAnOM4X+3U2smLeEOzzgfw");

public int ssSPLIT_KEY;

public string ssWI_TAX_TYPE;

public string ssWI_TAX_CODE;

public decimal ssWI_TAX_BASE;


public BitArray OptimizedAttributes;

public ST_646bfb521d5f3e3e304163b436da5220Structure() {
OptimizedAttributes = null;
ssSPLIT_KEY = -2147483648;
ssWI_TAX_TYPE = "";
ssWI_TAX_CODE = "";
ssWI_TAX_BASE = -79228162514264337593543950335m;
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
ssSPLIT_KEY = r.ReadInteger(index++, "TI_WXD_Out.SPLIT_KEY", 0);
ssWI_TAX_TYPE = r.ReadText(index++, "TI_WXD_Out.WI_TAX_TYPE", "");
ssWI_TAX_CODE = r.ReadText(index++, "TI_WXD_Out.WI_TAX_CODE", "");
ssWI_TAX_BASE = r.ReadDecimal(index++, "TI_WXD_Out.WI_TAX_BASE", 0.0M);
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
public void ReadIM(ST_646bfb521d5f3e3e304163b436da5220Structure r) {
this = r;
}


public static bool operator == (ST_646bfb521d5f3e3e304163b436da5220Structure a, ST_646bfb521d5f3e3e304163b436da5220Structure b) {
if (a.ssSPLIT_KEY != b.ssSPLIT_KEY) return false;
if (a.ssWI_TAX_TYPE != b.ssWI_TAX_TYPE) return false;
if (a.ssWI_TAX_CODE != b.ssWI_TAX_CODE) return false;
if (a.ssWI_TAX_BASE != b.ssWI_TAX_BASE) return false;
return true;
}

public static bool operator != (ST_646bfb521d5f3e3e304163b436da5220Structure a, ST_646bfb521d5f3e3e304163b436da5220Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_646bfb521d5f3e3e304163b436da5220Structure)) return false;
return (this == (ST_646bfb521d5f3e3e304163b436da5220Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSPLIT_KEY.GetHashCode()
 ^ ssWI_TAX_TYPE.GetHashCode()
 ^ ssWI_TAX_CODE.GetHashCode()
 ^ ssWI_TAX_BASE.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_646bfb521d5f3e3e304163b436da5220Structure Duplicate() {
ST_646bfb521d5f3e3e304163b436da5220Structure t;
t.ssSPLIT_KEY = this.ssSPLIT_KEY;
t.ssWI_TAX_TYPE = this.ssWI_TAX_TYPE;
t.ssWI_TAX_CODE = this.ssWI_TAX_CODE;
t.ssWI_TAX_BASE = this.ssWI_TAX_BASE;
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
if (head == "split_key") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SPLIT_KEY")) variable.Value = ssSPLIT_KEY; else variable.Optimized = true;
} else if (head == "wi_tax_type") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WI_TAX_TYPE")) variable.Value = ssWI_TAX_TYPE; else variable.Optimized = true;
} else if (head == "wi_tax_code") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WI_TAX_CODE")) variable.Value = ssWI_TAX_CODE; else variable.Optimized = true;
} else if (head == "wi_tax_base") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WI_TAX_BASE")) variable.Value = ssWI_TAX_BASE; else variable.Optimized = true;
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
if (key == IdSPLIT_KEY) {
return ssSPLIT_KEY;
}
if (key == IdWI_TAX_TYPE) {
return ssWI_TAX_TYPE;
}
if (key == IdWI_TAX_CODE) {
return ssWI_TAX_CODE;
}
if (key == IdWI_TAX_BASE) {
return ssWI_TAX_BASE;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSPLIT_KEY.Key.AsGuid) {
return ssSPLIT_KEY;
}
if (attributeKey == IdWI_TAX_TYPE.Key.AsGuid) {
return ssWI_TAX_TYPE;
}
if (attributeKey == IdWI_TAX_CODE.Key.AsGuid) {
return ssWI_TAX_CODE;
}
if (attributeKey == IdWI_TAX_BASE.Key.AsGuid) {
return ssWI_TAX_BASE;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSPLIT_KEY = (int) other.AttributeGet(IdSPLIT_KEY);
ssWI_TAX_TYPE = (string) other.AttributeGet(IdWI_TAX_TYPE);
ssWI_TAX_CODE = (string) other.AttributeGet(IdWI_TAX_CODE);
ssWI_TAX_BASE = (decimal) other.AttributeGet(IdWI_TAX_BASE);
}
} // ST_646bfb521d5f3e3e304163b436da5220Structure
/// <summary>
/// RecordList type <code>TI_WXD_OutList</code> that represents a record list of
///  <code>TI_WXD_Out</code>
/// </summary>
public partial class RL_ede476728417dba9bcd8aba956158c2a : GenericRecordList<ST_646bfb521d5f3e3e304163b436da5220Structure>, IEnumerable, IEnumerator {

protected override ST_646bfb521d5f3e3e304163b436da5220Structure GetElementDefaultValue() {
return new ST_646bfb521d5f3e3e304163b436da5220Structure();
}

public T[] ToArray<T>(Func<ST_646bfb521d5f3e3e304163b436da5220Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ede476728417dba9bcd8aba956158c2a recordList, Func<ST_646bfb521d5f3e3e304163b436da5220Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ede476728417dba9bcd8aba956158c2a(ST_646bfb521d5f3e3e304163b436da5220Structure[] array) {
  RL_ede476728417dba9bcd8aba956158c2a result = new RL_ede476728417dba9bcd8aba956158c2a();
result.InnerFromArray(array);
    return result;
}

public static RL_ede476728417dba9bcd8aba956158c2a ToList<T>(T[] array, Func <T, ST_646bfb521d5f3e3e304163b436da5220Structure> converter) {
  RL_ede476728417dba9bcd8aba956158c2a result = new RL_ede476728417dba9bcd8aba956158c2a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ede476728417dba9bcd8aba956158c2a FromRestList<T>(RestList<T> restList, Func <T, ST_646bfb521d5f3e3e304163b436da5220Structure> converter) {
  RL_ede476728417dba9bcd8aba956158c2a result = new RL_ede476728417dba9bcd8aba956158c2a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ede476728417dba9bcd8aba956158c2a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_646bfb521d5f3e3e304163b436da5220Structure> NewList() {
return new RL_ede476728417dba9bcd8aba956158c2a();
}


} // RL_ede476728417dba9bcd8aba956158c2a
}

