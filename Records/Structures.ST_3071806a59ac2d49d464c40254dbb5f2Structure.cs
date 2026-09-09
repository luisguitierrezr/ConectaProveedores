namespace ssConectaProveedores {
/// <summary>
/// [Structure] DocumentExtrationPeriod (Y5sF3F+EUEK61GUOCFWzSg)
///  <code>ST_3071806a59ac2d49d464c40254dbb5f2Structure</code> that represent
/// s <code>DocumentExtrationPeriod</code> <p>Description: </p>
/// </summary>
// Name: DocumentExtrationPeriod
public partial struct ST_3071806a59ac2d49d464c40254dbb5f2Structure : ITypedRecord<ST_3071806a59ac2d49d464c40254dbb5f2Structure> {
internal static readonly GlobalObjectKey IdSpace = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Y2gVtdzwQUCcskplJt67CQ");
internal static readonly GlobalObjectKey IdDesde = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*s08CcRk860mkw7fEZjdWPQ");
internal static readonly GlobalObjectKey IdHasta = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*oyPy1f+ASESWz1B9Kes4GQ");
internal static readonly GlobalObjectKey IdSpace2 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*BtOosRoCd0y9KbzeSzbioQ");
internal static readonly GlobalObjectKey IdDesde2 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*b7DzAEwM306Gra99F_fj0g");
internal static readonly GlobalObjectKey IdHasta2 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*txVrX0W200msjVKEdOrwhg");

public string ssSpace;

public string ssDesde;

public string ssHasta;

public string ssSpace2;

public string ssDesde2;

public string ssHasta2;


public BitArray OptimizedAttributes;

public ST_3071806a59ac2d49d464c40254dbb5f2Structure() {
OptimizedAttributes = null;
ssSpace = "";
ssDesde = "";
ssHasta = "";
ssSpace2 = "";
ssDesde2 = "";
ssHasta2 = "";
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
ssSpace = r.ReadText(index++, "DocumentExtrationPeriod.Space", "");
ssDesde = r.ReadText(index++, "DocumentExtrationPeriod.Desde", "");
ssHasta = r.ReadText(index++, "DocumentExtrationPeriod.Hasta", "");
ssSpace2 = r.ReadText(index++, "DocumentExtrationPeriod.Space2", "");
ssDesde2 = r.ReadText(index++, "DocumentExtrationPeriod.Desde2", "");
ssHasta2 = r.ReadText(index++, "DocumentExtrationPeriod.Hasta2", "");
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
public void ReadIM(ST_3071806a59ac2d49d464c40254dbb5f2Structure r) {
this = r;
}


public static bool operator == (ST_3071806a59ac2d49d464c40254dbb5f2Structure a, ST_3071806a59ac2d49d464c40254dbb5f2Structure b) {
if (a.ssSpace != b.ssSpace) return false;
if (a.ssDesde != b.ssDesde) return false;
if (a.ssHasta != b.ssHasta) return false;
if (a.ssSpace2 != b.ssSpace2) return false;
if (a.ssDesde2 != b.ssDesde2) return false;
if (a.ssHasta2 != b.ssHasta2) return false;
return true;
}

public static bool operator != (ST_3071806a59ac2d49d464c40254dbb5f2Structure a, ST_3071806a59ac2d49d464c40254dbb5f2Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_3071806a59ac2d49d464c40254dbb5f2Structure)) return false;
return (this == (ST_3071806a59ac2d49d464c40254dbb5f2Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSpace.GetHashCode()
 ^ ssDesde.GetHashCode()
 ^ ssHasta.GetHashCode()
 ^ ssSpace2.GetHashCode()
 ^ ssDesde2.GetHashCode()
 ^ ssHasta2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_3071806a59ac2d49d464c40254dbb5f2Structure Duplicate() {
ST_3071806a59ac2d49d464c40254dbb5f2Structure t;
t.ssSpace = this.ssSpace;
t.ssDesde = this.ssDesde;
t.ssHasta = this.ssHasta;
t.ssSpace2 = this.ssSpace2;
t.ssDesde2 = this.ssDesde2;
t.ssHasta2 = this.ssHasta2;
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
if (head == "space") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Space")) variable.Value = ssSpace; else variable.Optimized = true;
} else if (head == "desde") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Desde")) variable.Value = ssDesde; else variable.Optimized = true;
} else if (head == "hasta") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Hasta")) variable.Value = ssHasta; else variable.Optimized = true;
} else if (head == "space2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Space2")) variable.Value = ssSpace2; else variable.Optimized = true;
} else if (head == "desde2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Desde2")) variable.Value = ssDesde2; else variable.Optimized = true;
} else if (head == "hasta2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Hasta2")) variable.Value = ssHasta2; else variable.Optimized = true;
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
if (key == IdSpace) {
return ssSpace;
}
if (key == IdDesde) {
return ssDesde;
}
if (key == IdHasta) {
return ssHasta;
}
if (key == IdSpace2) {
return ssSpace2;
}
if (key == IdDesde2) {
return ssDesde2;
}
if (key == IdHasta2) {
return ssHasta2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSpace.Key.AsGuid) {
return ssSpace;
}
if (attributeKey == IdDesde.Key.AsGuid) {
return ssDesde;
}
if (attributeKey == IdHasta.Key.AsGuid) {
return ssHasta;
}
if (attributeKey == IdSpace2.Key.AsGuid) {
return ssSpace2;
}
if (attributeKey == IdDesde2.Key.AsGuid) {
return ssDesde2;
}
if (attributeKey == IdHasta2.Key.AsGuid) {
return ssHasta2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSpace = (string) other.AttributeGet(IdSpace);
ssDesde = (string) other.AttributeGet(IdDesde);
ssHasta = (string) other.AttributeGet(IdHasta);
ssSpace2 = (string) other.AttributeGet(IdSpace2);
ssDesde2 = (string) other.AttributeGet(IdDesde2);
ssHasta2 = (string) other.AttributeGet(IdHasta2);
}
} // ST_3071806a59ac2d49d464c40254dbb5f2Structure
/// <summary>
/// RecordList type <code>DocumentExtrationPeriodList</code> that represents a record list of
///  <code>DocumentExtrationPeriod</code>
/// </summary>
public partial class RL_54d10930f184f2d93d77aca8dba6a618 : GenericRecordList<ST_3071806a59ac2d49d464c40254dbb5f2Structure>, IEnumerable, IEnumerator {

protected override ST_3071806a59ac2d49d464c40254dbb5f2Structure GetElementDefaultValue() {
return new ST_3071806a59ac2d49d464c40254dbb5f2Structure();
}

public T[] ToArray<T>(Func<ST_3071806a59ac2d49d464c40254dbb5f2Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_54d10930f184f2d93d77aca8dba6a618 recordList, Func<ST_3071806a59ac2d49d464c40254dbb5f2Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_54d10930f184f2d93d77aca8dba6a618(ST_3071806a59ac2d49d464c40254dbb5f2Structure[] array) {
  RL_54d10930f184f2d93d77aca8dba6a618 result = new RL_54d10930f184f2d93d77aca8dba6a618();
result.InnerFromArray(array);
    return result;
}

public static RL_54d10930f184f2d93d77aca8dba6a618 ToList<T>(T[] array, Func <T, ST_3071806a59ac2d49d464c40254dbb5f2Structure> converter) {
  RL_54d10930f184f2d93d77aca8dba6a618 result = new RL_54d10930f184f2d93d77aca8dba6a618();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_54d10930f184f2d93d77aca8dba6a618 FromRestList<T>(RestList<T> restList, Func <T, ST_3071806a59ac2d49d464c40254dbb5f2Structure> converter) {
  RL_54d10930f184f2d93d77aca8dba6a618 result = new RL_54d10930f184f2d93d77aca8dba6a618();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_54d10930f184f2d93d77aca8dba6a618() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_3071806a59ac2d49d464c40254dbb5f2Structure> NewList() {
return new RL_54d10930f184f2d93d77aca8dba6a618();
}


} // RL_54d10930f184f2d93d77aca8dba6a618
}

